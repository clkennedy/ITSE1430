using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public interface IContactItem
    {
        string ContactName { get; set; }

        void Send( string subject, MessageItem messageItem, IMessageService service);
    }
}
