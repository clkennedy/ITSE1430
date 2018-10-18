using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class ContactItem : IContactItem
    {
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }

        public void Send( string subject, MessageItem messageItem, IMessageService service )
        {
            service.Send(messageItem);
        }

        public override string ToString()
        {
            return ContactName;
        }
    }
}
