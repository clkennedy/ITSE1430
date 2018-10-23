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
    public partial class MessageForm : Form
    {
        public ContactItem Contact { get; set; } = null;
        public MessageForm()
        {
            InitializeComponent();
        }

        

        private bool ValidateFields()
        {
            bool isValid = true;

            if (!IsValidEmail(tbMessage.Text))
            {
                isValid = false;
                errorProvider.SetError(tbMessage, "Email is not valid");
            }
            
                
            return isValid;
        }
        private void SaveData()
        {
            if (Contact == null)
                Contact = new ContactItem();

            Contact.ContactName = tbSubject.Text;
            Contact.ContactEmail = tbMessage.Name;
        }
        bool IsValidEmail( string source )
        {
            try
            {
                new System.Net.Mail.MailAddress(source);
                return true;
            } catch
            { };

            return false;
        }

        private void ContactForm_Load( object sender, EventArgs e )
        {
            if(Contact != null)
            {
                Name = "Editing " + Contact.ContactName;
                tbSubject.Text = Contact.ContactName;
                tbMessage.Text = Contact.ContactEmail;
                ValidateFields();
            } else
            {
                Name = "New Contact";
            }
        }

        private void OnTextBoxChange( object sender, EventArgs e )
        {
            bSend.Enabled = (tbSubject.Text != "" && tbMessage.Text != "");
        }

        private void OnSave( object sender, EventArgs e )
        {
            if (ValidateFields())
            {
                DialogResult = DialogResult.OK;
                SaveData();
                Close();
            }
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
