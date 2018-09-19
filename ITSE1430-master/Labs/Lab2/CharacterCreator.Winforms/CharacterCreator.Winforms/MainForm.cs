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

        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ExitProgram();
        }

        private void ExitProgram()
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click( object sender, EventArgs e )
        {
            AboutForm aboutForm = new AboutForm();

            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.ShowDialog(this);
        }

        private void newToolStripMenuItem_Click( object sender, EventArgs e )
        {
            NewCharacterForm characterForm = new NewCharacterForm();
            this.AddOwnedForm(characterForm);

            Character newCharacter = characterForm.ShowWindow(this);

            this.characterList[currentNumberOfCharacters++] = newCharacter;
            
        }

        public void RefreshList()
        {
            listBoxCharacterList.DataSource = null;

        }

        private void MainForm_Load( object sender, EventArgs e )
        {

        }
    }
}
