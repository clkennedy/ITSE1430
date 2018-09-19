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
        public NewCharacterForm()
        {
            InitializeComponent();
            
            comboBoxClassType.DataSource = Enum.GetValues(typeof(Character.ClassType));
            comboBoxRace.DataSource = Enum.GetValues(typeof(Character.Race));
        }

        private void textBoxName_TextChanged( object sender, EventArgs e )
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

        private void saveButton_Click( object sender, EventArgs e )
        {
            //ToDo: add save CharacterLogic
            this.Close();
        }

        private void cancelButton_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void strScrollBar_ValueChanged( object sender, EventArgs e )
        {
            strScoreLabel.Text = strScrollBar.Value.ToString();
        }

        private void intelScrollBar_ValueChanged( object sender, EventArgs e )
        {
            intelScoreLabel.Text = intelScrollBar.Value.ToString();
        }

        private void dexScrollBar_Scroll( object sender, ScrollEventArgs e )
        {
            dexScoreLabel.Text = dexScrollBar.Value.ToString();
        }

        private void conScrollBar_Scroll( object sender, ScrollEventArgs e )
        {
            conScoreLabel.Text = conScrollBar.Value.ToString();
        }

        private void wisScrollBar_Scroll( object sender, ScrollEventArgs e )
        {
            wisScorLabel.Text = wisScrollBar.Value.ToString();
        }

        private void charScrollBar_Scroll( object sender, ScrollEventArgs e )
        {
            charScoreLabel.Text = charScrollBar.Value.ToString();
        }

        private void luckScrollBar_Scroll( object sender, ScrollEventArgs e )
        {
            luckScoreLabel.Text = luckScrollBar.Value.ToString();
        }

        public Character ShowWindow(IWin32Window owner)
        {
            base.ShowDialog(owner);
            Character newCharacter = new Character(textBoxName.Text, textBoxBio.Text,
                (Character.ClassType)comboBoxClassType.SelectedItem,
                (Character.Race)comboBoxRace.SelectedItem);

            newCharacter.SetAttribute(Attribute.STRENGTH, strScrollBar.Value);
            newCharacter.SetAttribute(Attribute.DEXERITY, dexScrollBar.Value);
            newCharacter.SetAttribute(Attribute.CONSTITUTION, conScrollBar.Value);
            newCharacter.SetAttribute(Attribute.CHARISMA, charScrollBar.Value);
            newCharacter.SetAttribute(Attribute.INTELLEGENCE, intelScrollBar.Value);
            newCharacter.SetAttribute(Attribute.WISDOM, wisScrollBar.Value);
            newCharacter.SetAttribute(Attribute.LUCK, luckScrollBar.Value);

            return newCharacter;
        }
    }
}
