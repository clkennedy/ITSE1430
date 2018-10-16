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

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        CharacterDatabase _charDB = new CharacterDatabase();
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitProgramOnClick(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void ExitProgram()
        {
            this.Close();
        }

        private void AboutFormOnClick(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();

            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.ShowDialog(this);
        }
        public void RefreshList()
        {
            listBoxCharacterList.DataSource = null;
            listBoxCharacterList.DataSource = _charDB.Characters;
        }
        public void RemoveCharacter()
        {
            if (this.listBoxCharacterList.SelectedItem == null) return;

            Character character = GetSelectedCharacter();

            if (MessageBox.Show(this, $"Delete {character.CharacterName}?", "Delete?", MessageBoxButtons.YesNo) == DialogResult.No) return;

            _charDB.Remove(character);
            
            RefreshList();
        }
        public void EditCharacter()
        {
            if (listBoxCharacterList.SelectedItem != null)
            {
                CharacterForm cf = new CharacterForm();
                cf.Character = GetSelectedCharacter();
                cf.ShowDialog();
                RefreshList();
            }
        }

        private Character GetSelectedCharacter()
        {
            if (listBoxCharacterList.SelectedItem != null)
            {
                return listBoxCharacterList.SelectedItem as Character;
            }
            return null;
        }
        public void NewCharacter()
        {
            CharacterForm characterForm = new CharacterForm();
            characterForm.ShowDialog(this);
            Character newCharacter = characterForm.Character;
            if (newCharacter != null)
            {
                _charDB.Add(newCharacter);
                RefreshList();
            }
        }

        private void LoadMainForm(object sender, EventArgs e)
        {
            RefreshList();
        }


        private void NewCharacterOnClick( object sender, EventArgs e )
        {
            NewCharacter();
        }
        private void DoubleClickCharacterInListBox(object sender, EventArgs e)
        {
            EditCharacter();
        }

        private void EditCharcterOnClick(object sender, EventArgs e)
        {
            EditCharacter();
        }

        private void DeleteCharacterOnClick(object sender, EventArgs e)
        {
            RemoveCharacter();
        }
    }
}
