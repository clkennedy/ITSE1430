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
        public MessageItem Message { get; set; } = null;
        public MessageForm()
        {
            InitializeComponent();
        }

        

        private bool ValidateFields()
        {
            bool isValid = true;

            if (tbSubject.Text == "")
            {
                isValid = false;
                errorProvider.SetError(tbSubject, "Subject can't be Empty");
            }
            
                
            return isValid;
        }
        private void SaveData()
        {
            if (Message == null)
                Message = new MessageItem();

            Message.MessageEmail = Contact.ContactEmail;
            Message.MessageSubject = tbSubject.Text;
            Message.MessageBody = tbMessage.Text;
        }
        

        private void ContactForm_Load( object sender, EventArgs e )
        {
            if(Contact != null)
            {
                Name = "Send Message to " + Contact.ContactName;
                ValidateFields();
            } else
            {
                Name = "Send Message";
            }
        }

        private void OnTextBoxChange( object sender, EventArgs e )
        {
            bSend.Enabled = (tbSubject.Text != "");
        }

        private void OnSend( object sender, EventArgs e )
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
