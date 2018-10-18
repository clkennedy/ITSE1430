using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class MainForm : Form
    {
        private ContactDatabase _contactDB = new ContactDatabase();
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void RefreshList()
        {
            lbContacts.DataSource = null;
            lbContacts.DataSource = _contactDB.Contacts;
        }

        private void OnAboutClicked( object sender, EventArgs e )
        {
            new AboutForm().ShowDialog(this);
        }

        private void OnExitClicked( object sender, EventArgs e )
        {
            Close();
        }

        private void OnNewContact( object sender, EventArgs e )
        {
            ContactForm cf = new ContactForm();
            cf.ShowDialog(this);

            if (cf.Contact != null)
                _contactDB.Add(cf.Contact);

            RefreshList();
        }
    }
}
