using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class ContactDatabase
    {
        private List<ContactItem> _contacts = new List<ContactItem>();

        public List<ContactItem> Contacts {
            get { return _contacts; }
        }

        public void Add(ContactItem contact )
        {
            if (contact == null)
                throw new Exception("Contact cannot be null");

            _contacts.Add(contact);
        }
    }
}
