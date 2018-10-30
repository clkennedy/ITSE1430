using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public class FormMessageService : IMessageService
    {
        public MainForm MainForm { get; set; } = null;
        public FormMessageService(MainForm form )
        {
            MainForm = form;
        }
        public void Send( MessageItem message )
        {
            if(MainForm == null)
            {
                return;
            }
            string messages = MainForm.MessageText.Text;

            if (messages != "")
            {
                MainForm.MessageText.SelectionFont = new System.Drawing.Font(MainForm.MessageText.Font, System.Drawing.FontStyle.Bold);
                MainForm.MessageText.AppendText("--------------------------------------------------------\r\n");
            }

            MainForm.MessageText.SelectionFont = new System.Drawing.Font(MainForm.MessageText.Font, System.Drawing.FontStyle.Bold);
            MainForm.MessageText.AppendText("Email: ");
            MainForm.MessageText.SelectionFont = new System.Drawing.Font(MainForm.MessageText.Font, System.Drawing.FontStyle.Regular);
            MainForm.MessageText.AppendText($"{message.MessageEmail}\r\n");

            MainForm.MessageText.SelectionFont = new System.Drawing.Font(MainForm.MessageText.Font, System.Drawing.FontStyle.Bold);
            MainForm.MessageText.AppendText("Subject: ");
            MainForm.MessageText.SelectionFont = new System.Drawing.Font(MainForm.MessageText.Font, System.Drawing.FontStyle.Regular);
            MainForm.MessageText.AppendText($"{message.MessageSubject}\r\n");

            MainForm.MessageText.SelectionFont = new System.Drawing.Font(MainForm.MessageText.Font, System.Drawing.FontStyle.Bold);
            MainForm.MessageText.AppendText("Body:\r\n");
            MainForm.MessageText.SelectionFont = new System.Drawing.Font(MainForm.MessageText.Font, System.Drawing.FontStyle.Regular);
            MainForm.MessageText.AppendText($"{message.MessageBody}\r\n");
        }

    }
}
