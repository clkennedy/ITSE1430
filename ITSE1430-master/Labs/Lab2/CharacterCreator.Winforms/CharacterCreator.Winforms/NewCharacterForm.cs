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
    public partial class NewCharacterForm : Form
    {
        private bool _saveChar = false;
        public NewCharacterForm()
        {
            InitializeComponent();
            
            comboBoxClassType.DataSource = Enum.GetValues(typeof(Character.ClassType));
            comboBoxRace.DataSource = Enum.GetValues(typeof(Character.Race));

            for(int i = 0; i < this.Controls.Count; i ++)
            {
                this.Controls[i].KeyPress += AnyKeyPressToCloseForm;
            }

        }

        private void NameTextBoxChanged( object sender, EventArgs e )
        {
            if(textBoxName.Text.Length < 3)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Name Too Short";
                saveButton.Enabled = false;
                return;
            }
            if (textBoxName.Text.Any(ch => (!Char.IsLetter(ch) && !ch.Equals(' ')))){
                errorLabel.Visible = true;
                errorLabel.Text = "No Special Chars";
                saveButton.Enabled = false;
                return;
            }
            if(textBoxName.Text[0].Equals(' '))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Can't Begin With Space";
                saveButton.Enabled = false;
                return;
            }
            errorLabel.Visible = false;
            saveButton.Enabled = true;
        }

        private void SaveButtonOnClick( object sender, EventArgs e )
        {
            this._saveChar = true;
            this.Close();
        }

        private void CancelButtonOnClick( object sender, EventArgs e )
        {
            this._saveChar = false;
            this.Close();
        }

        private void StrengthScrollBarValueChanged( object sender, EventArgs e )
        {
            strScoreLabel.Text = strScrollBar.Value.ToString();
        }

        private void IntellegenceScrollBarValueChanged( object sender, EventArgs e )
        {
            intelScoreLabel.Text = intelScrollBar.Value.ToString();
        }
        
        private void DexterityScrollBarValueChanged(object sender, EventArgs e)
        {
            dexScoreLabel.Text = dexScrollBar.Value.ToString();
        }

        private void ConstitutionScrollBarValueChanged(object sender, EventArgs e)
        {
            conScoreLabel.Text = conScrollBar.Value.ToString();
        }
        private void WisdomScrollBarValueChanged(object sender, EventArgs e)
        {
            wisScorLabel.Text = wisScrollBar.Value.ToString();
        }
        
        private void CharismaScrollBarValueChanged(object sender, EventArgs e)
        {
            charScoreLabel.Text = charScrollBar.Value.ToString();
        }

        private void LuckScrollBarValueChanged(object sender, EventArgs e)
        {
            luckScoreLabel.Text = luckScrollBar.Value.ToString();
        }

        public Character ShowWindow(IWin32Window owner)
        {
            base.ShowDialog(owner);
            Character newCharacter = null;

            if (this._saveChar)
            {
            newCharacter = new Character(textBoxName.Text, textBoxBio.Text,
                (Character.ClassType)comboBoxClassType.SelectedItem,
                (Character.Race)comboBoxRace.SelectedItem);

            newCharacter.SetAttribute(Attribute.STRENGTH, strScrollBar.Value);
            newCharacter.SetAttribute(Attribute.DEXERITY, dexScrollBar.Value);
            newCharacter.SetAttribute(Attribute.CONSTITUTION, conScrollBar.Value);
            newCharacter.SetAttribute(Attribute.CHARISMA, charScrollBar.Value);
            newCharacter.SetAttribute(Attribute.INTELLEGENCE, intelScrollBar.Value);
            newCharacter.SetAttribute(Attribute.WISDOM, wisScrollBar.Value);
            newCharacter.SetAttribute(Attribute.LUCK, luckScrollBar.Value);
            }

            return newCharacter;
        }
        public Character ShowWindow(IWin32Window owner, Character character)
        {
            textBoxName.Text = character.CharacterName;
            textBoxBio.Text = character.CharacterDescription;
            comboBoxClassType.SelectedItem = (Object)character.CharacterClassType;
            comboBoxRace.SelectedItem = (Object)character.CharacterRace;

            strScrollBar.Value = character.GetAttribute(Attribute.STRENGTH);
            dexScrollBar.Value = character.GetAttribute(Attribute.DEXERITY);
            conScrollBar.Value = character.GetAttribute(Attribute.CONSTITUTION);
            charScrollBar.Value = character.GetAttribute(Attribute.CHARISMA);
            intelScrollBar.Value = character.GetAttribute(Attribute.INTELLEGENCE);
            wisScrollBar.Value = character.GetAttribute(Attribute.WISDOM);
            luckScrollBar.Value = character.GetAttribute(Attribute.LUCK);


            base.ShowDialog(owner);

            if (this._saveChar)
            {
                character.CharacterName = textBoxName.Text;
                character.CharacterDescription = textBoxBio.Text;
                character.CharacterClassType = (Character.ClassType)comboBoxClassType.SelectedItem;
                character.CharacterRace = (Character.Race)comboBoxRace.SelectedItem;
                character.SetAttribute(Attribute.STRENGTH, strScrollBar.Value);
                character.SetAttribute(Attribute.DEXERITY, dexScrollBar.Value);
                character.SetAttribute(Attribute.CONSTITUTION, conScrollBar.Value);
                character.SetAttribute(Attribute.CHARISMA, charScrollBar.Value);
                character.SetAttribute(Attribute.INTELLEGENCE, intelScrollBar.Value);
                character.SetAttribute(Attribute.WISDOM, wisScrollBar.Value);
                character.SetAttribute(Attribute.LUCK, luckScrollBar.Value);
            }
            return character;
        }

        private void AnyKeyPressToCloseForm(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter) && this.saveButton.Enabled){
                this._saveChar = true;
                this.Close();
            }
            else if (e.KeyChar.Equals((char)Keys.Escape))
            {
                this.Close();
            }
            
        }
    }
}
