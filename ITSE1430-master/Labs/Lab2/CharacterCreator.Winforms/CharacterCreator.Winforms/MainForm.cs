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
        private Character[] characterList = new Character[100];
        private int currentNumberOfCharacters = 0;
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

        private void NewCharacterOnClick(object sender, EventArgs e)
        {
            CharacterForm characterForm = new CharacterForm();
            this.AddOwnedForm(characterForm);

            Character newCharacter = characterForm.ShowWindow(this);
            if(newCharacter != null)
            {
                this.characterList[currentNumberOfCharacters++] = newCharacter;
                RefreshList();
                if(currentNumberOfCharacters == this.characterList.Length - 1)
                {
                    IncreaseArraySize();
                }
            }
        }

        public void RefreshList()
        {
            listBoxCharacterList.DataSource = null;
            listBoxCharacterList.DataSource = characterList;
        }
        public void RemoveCharacter()
        {
            if (this.listBoxCharacterList.SelectedItem == null) return;

            Character character = (Character)listBoxCharacterList.SelectedItem;

            if (MessageBox.Show(this, $"Delete {character.CharacterName}?", "Delete?", MessageBoxButtons.YesNo) == DialogResult.No) return;

            int indexOfChar = -1;
            for (int i = 0; i < this.currentNumberOfCharacters; i++)
            {
                if (this.characterList[i] == character)
                {
                    indexOfChar = i;
                }
            }

            if (indexOfChar != -1)
            {
                for (int i = indexOfChar; i < this.currentNumberOfCharacters; i++)
                {
                    if (i < this.characterList.Length - 1)
                    {
                        this.characterList[i] = this.characterList[i + 1];
                    }
                    else
                    {
                        IncreaseArraySize();
                    }

                }
            }
            currentNumberOfCharacters--;
            RefreshList();
        }

        private void IncreaseArraySize()
        {
            Character[] newCharacterSizeList = new Character[this.characterList.Length * 2];
            for (int i = 0; i < characterList.Length; i++)
            {
                newCharacterSizeList[i] = this.characterList[i];
            }
            this.characterList = newCharacterSizeList;
            newCharacterSizeList = null;
        }

        private void LoadMainForm(object sender, EventArgs e)
        {

        }

        public void EditCharacter()
        {
            if (listBoxCharacterList.SelectedItem != null)
            {
                new CharacterForm().ShowWindow(this, (Character)listBoxCharacterList.SelectedItem);
                RefreshList();
            }
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
