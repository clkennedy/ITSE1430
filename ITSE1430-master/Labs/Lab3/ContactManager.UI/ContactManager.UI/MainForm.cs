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
        public RichTextBox MessageText {
            get { return tbMessages; }
            set { tbMessages = value; } }

        public FormMessageService MessageService { get; set; }
        public MainForm()
        {
            InitializeComponent();
            MessageService = new FormMessageService(this);
        }
        
        private void RefreshList()
        {
            lbContacts.DataSource = null;
            lbContacts.DataSource = _contactDB.Contacts;
        }

        private void EditContact()
        {
            ContactItem contactItem = GetSelectedContact();
            if (contactItem == null)
                return;
            ContactForm cf = new ContactForm();
            cf.Contact = contactItem;

            cf.ShowDialog(this);

            RefreshList();
        }

        private void DeleteContact()
        {
            ContactItem contactItem = GetSelectedContact();
            if (contactItem == null)
                return;

            if (MessageBox.Show(this, $"Delete {contactItem.ContactName}", $"Are you sure you want to Delete {contactItem.ContactName} from your Contacts",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            _contactDB.Remove(contactItem);

            RefreshList();
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

        private void OnSendMessage( object sender, EventArgs e )
        {
            MessageForm mf = new MessageForm();
            ContactItem ci = GetSelectedContact();
            if (ci == null)
                return;
            mf.Contact = ci;
            mf.ShowDialog(this);

            if (mf.Message != null)
                MessageService.Send(mf.Message);
        }

        public ContactItem GetSelectedContact()
        {
            if (lbContacts.SelectedItem != null)
                return lbContacts.SelectedItem as ContactItem;

            return null;
        }

        private void editToolStripMenuItem_Click( object sender, EventArgs e )
        {
            EditContact();
        }

        private void OnContactDoubleClicked( object sender, EventArgs e )
        {
            EditContact();
        }

        private void OnContactDelete( object sender, EventArgs e )
        {
            DeleteContact();
        }

        private void tbMessages_TextChanged( object sender, EventArgs e )
        {

        }
    }
}
