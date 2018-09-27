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
        public CharacterForm()
        {
            InitializeComponent();
            
            comboBoxClassType.DataSource = Enum.GetValues(typeof(Character.ClassType));
            comboBoxRace.DataSource = Enum.GetValues(typeof(Character.Race));

            for(int i = 0; i < this.Controls.Count; i ++)
            {
                if (!this.Controls[i].Name.Equals("textBoxBio"))
                {
                    this.Controls[i].KeyPress += AnyKeyPressToCloseForm;
                }
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
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButtonOnClick( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #region Attributes
        private void StrengthScrollBarValueChanged( object sender, EventArgs e )
        {
            if (HasAvailablePoints())
            {
                strScoreLabel.Text = strScrollBar.Value.ToString();
            } else
            {
                strScrollBar.Value--;
            }
            
        }

        private void IntellegenceScrollBarValueChanged( object sender, EventArgs e )
        {
            if (HasAvailablePoints())
            {
                intelScoreLabel.Text = intelScrollBar.Value.ToString();
            } else
            {
                intelScrollBar.Value--;
            }
        }
        
        private void DexterityScrollBarValueChanged(object sender, EventArgs e)
        {
            if (HasAvailablePoints())
            {
                dexScoreLabel.Text = dexScrollBar.Value.ToString();
            } else
            {
                dexScrollBar.Value--;
            }
        }

        private void ConstitutionScrollBarValueChanged(object sender, EventArgs e)
        {
            if (HasAvailablePoints())
            {
                conScoreLabel.Text = conScrollBar.Value.ToString();
            } else
            {
                conScrollBar.Value--;
            }
        }
        private void WisdomScrollBarValueChanged(object sender, EventArgs e)
        {
            if (HasAvailablePoints())
            {
                wisScorLabel.Text = wisScrollBar.Value.ToString();
            } else
            {
                wisScrollBar.Value--;
            }
        }
        
        private void CharismaScrollBarValueChanged(object sender, EventArgs e)
        {
            if (HasAvailablePoints())
            {
                charScoreLabel.Text = charScrollBar.Value.ToString();
            } else
            {
                charScrollBar.Value--;
            }
        }

        private void LuckScrollBarValueChanged(object sender, EventArgs e)
        {
            if (HasAvailablePoints())
            {
                luckScoreLabel.Text = luckScrollBar.Value.ToString();
            } else
            {
                luckScrollBar.Value--;
            }
        }
        #endregion

        #region CustomShowWindows
        public Character ShowWindow(IWin32Window owner)
        {
            base.ShowDialog(owner);
            return SaveCharacter(null);
        }
        public Character ShowWindow(IWin32Window owner, Character character)
        {
            this.Name = $"Edit Character: {character.CharacterName}";
            SetCharacterValues(character);
            
            base.ShowDialog(owner);

            return SaveCharacter(character);
        }
        #endregion

        private bool HasAvailablePoints()
        {
            int pointsAvail = Attribute.TOTAL_ALLOCATED_POINTS_ALLOWED -
                (luckScrollBar.Value +
                strScrollBar.Value +
                intelScrollBar.Value +
                dexScrollBar.Value +
                conScrollBar.Value +
                charScrollBar.Value +
                wisScrollBar.Value);

            labelPointsAvail.Text = pointsAvail.ToString();

            if (pointsAvail >= 0)
                return true;
            
            return false;
        }
        private void SetCharacterValues(Character character )
        {
            textBoxName.Text = character.CharacterName;
            textBoxBio.Text = character.CharacterDescription;
            comboBoxClassType.SelectedItem = (object)character.CharacterClassType;
            comboBoxRace.SelectedItem = (object)character.CharacterRace;

            strScrollBar.Value = character.GetAttribute(Attribute.STRENGTH);
            dexScrollBar.Value = character.GetAttribute(Attribute.DEXERITY);
            conScrollBar.Value = character.GetAttribute(Attribute.CONSTITUTION);
            charScrollBar.Value = character.GetAttribute(Attribute.CHARISMA);
            intelScrollBar.Value = character.GetAttribute(Attribute.INTELLEGENCE);
            wisScrollBar.Value = character.GetAttribute(Attribute.WISDOM);
            luckScrollBar.Value = character.GetAttribute(Attribute.LUCK);
        }
        private Character SaveCharacter(Character character)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if(character == null)
                {
                    character = new Character();
                }

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
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (e.KeyChar.Equals((char)Keys.Escape))
            {
                this.Close();
            }
        }

        private void CharacterForm_Load( object sender, EventArgs e )
        {
            HasAvailablePoints();
        }
    }
}
