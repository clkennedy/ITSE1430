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
            saveButton.Enabled = (textBoxName.Text != "");
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
    }
}
