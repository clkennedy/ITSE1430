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
            string messages = MainForm.MessageBox;

            if (messages != "")
                messages += "\r\n--------------\r\n";
            messages += $"Email: \r\n{message.MessageEmail}\r\n" +
                $"Subject:\r\n{message.MessageSubject}\r\n" +
                $"Body:\r\n{message.MessageBody}";

            MainForm.MessageBox = messages;
        }
    }
}
