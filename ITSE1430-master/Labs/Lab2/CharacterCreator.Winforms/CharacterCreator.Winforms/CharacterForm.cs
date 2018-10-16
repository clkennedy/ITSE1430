/*
 * Author : Cameron Kennedy
 * ITSE 1430
 * 9/20/2018 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public Character Character { get; set; } = null;
        private bool loaded = false;
        public CharacterForm()
        {
            InitializeComponent();
            
            comboBoxClassType.DataSource = Enum.GetValues(typeof(ClassType));
            comboBoxRace.DataSource = Enum.GetValues(typeof(Race));

            //this is for being able to hit enter and validate from any control, i used this instead of the accppet button
            //because i wante dthe user to be able to use enter in the bio text box
            for(int i = 0; i < this.Controls.Count; i ++)
            {
                if (this.Controls[i] != textBoxBio)
                {
                    this.Controls[i].KeyPress += AnyKeyPressToCloseForm;
                }
            }
        }

        private void NameTextBoxChanged( object sender, EventArgs e )
        {
            if(textBoxName.Text.Length < 3)
            {
                errorLabel.Text = "Name Too Short";
                saveButton.Enabled = false;
            }
            else if (textBoxName.Text.Any(ch => (!Char.IsDigit(ch) && !Char.IsLetter(ch) && !ch.Equals(' ')))){
                errorLabel.Text = "No Special Chars";
                saveButton.Enabled = false;
            }
            else{
                errorLabel.Text = "";
                saveButton.Enabled = true;
            }
            errorProvider.SetError(textBoxName, errorLabel.Text);
            errorLabel.Visible = false;
            
        }

        private void SaveButtonOnClick( object sender, EventArgs e )
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButtonOnClick( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #region Attributes
        private void AttributValueChanged( object sender, EventArgs e )
        {
            //luck is disabled because in most games you dont have control ove rthe luck attribute, but its typically displayed for information purposes
            //thats thr oute i chose to go, plus if this were an actually game there might be a feat that will let you change luck
            if (!HasAvailablePoints() && sender is NumericUpDown nud)
            {
                nud.Value--;
            } 
        }
        #endregion

        private bool HasAvailablePoints()
        {
            if (!loaded)
                return true;

            int pointsAvail = CharacterAttribute.TotalAllocatedPointsAllowed -
                (int)(nudLuck.Value +
                nudCharisma.Value +
                nudIntellegence.Value +
                nudDexterity.Value +
                nudStrength.Value +
                nudWisdom.Value +
                nudConstitution.Value);

            labelPointsAvail.Text = pointsAvail.ToString();

            if (pointsAvail >= 0)
                return true;
            
            return false;
        }
        private void SetCharacterValues(Character character )
        {
            textBoxName.Text = character.CharacterName;
            textBoxBio.Text = character.CharacterDescription;
            comboBoxClassType.SelectedItem = character.CharacterClassType;
            comboBoxRace.SelectedItem = character.CharacterRace;

            nudStrength.Value = (decimal)character.GetAttribute(CharacterAttribute.Strength);
            nudDexterity.Value = character.GetAttribute(CharacterAttribute.Dexterity);
            nudConstitution.Value = character.GetAttribute(CharacterAttribute.Constitution);
            nudCharisma.Value = character.GetAttribute(CharacterAttribute.Charisma);
            nudIntellegence.Value = character.GetAttribute(CharacterAttribute.Intellegence);
            nudWisdom.Value = character.GetAttribute(CharacterAttribute.Wisdom);
            nudLuck.Value = character.GetAttribute(CharacterAttribute.Luck);
        }
        private void SaveCharacter()
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if(Character == null)
                {
                    Character = new Character();
                }

                Character.CharacterName = textBoxName.Text.Trim();
                Character.CharacterDescription = textBoxBio.Text;
                Character.CharacterClassType = (ClassType)comboBoxClassType.SelectedItem;
                Character.CharacterRace = (Race)comboBoxRace.SelectedItem;
                Character.SetAttribute(CharacterAttribute.Strength, (int)nudStrength.Value);
                Character.SetAttribute(CharacterAttribute.Dexterity, (int)nudDexterity.Value);
                Character.SetAttribute(CharacterAttribute.Constitution, (int)nudConstitution.Value);
                Character.SetAttribute(CharacterAttribute.Charisma, (int)nudCharisma.Value);
                Character.SetAttribute(CharacterAttribute.Intellegence, (int)nudIntellegence.Value);
                Character.SetAttribute(CharacterAttribute.Wisdom, (int)nudWisdom.Value);
                Character.SetAttribute(CharacterAttribute.Luck, (int)nudLuck.Value);
            }
        }

        private void AnyKeyPressToCloseForm(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter) && this.saveButton.Enabled){
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (e.KeyChar.Equals((char)Keys.Escape))
            {
                this.Close();
            }
        }

        protected override void OnFormClosing( FormClosingEventArgs e )
        {
            //you can save the character without using all the points as the player may want to allocate the points at a later date
            //plus you can edit the character, remove and add points so forcing the user to allocate all the points doesnt seem correct to me.
            base.OnFormClosing(e);
            if(DialogResult == DialogResult.OK)
            {
                SaveCharacter();
            }
        }

        private void CharacterForm_Load( object sender, EventArgs e )
        {
            if(Character != null)
            {
                this.Text = $"Edit Character: {Character.CharacterName}";
                SetCharacterValues(Character);
            }
            loaded = true;
            HasAvailablePoints();

        }
    }
}
