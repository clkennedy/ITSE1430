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

        public bool Add(ContactItem contact )
        {
            if (contact == null)
                throw new Exception("Contact cannot be null");

            if(_contacts.FindAll(con => con.ContactName.Equals(contact.ContactName)).Count > 0)
            {
                return false;
            }

            _contacts.Add(contact);
            return true;
        }

        public void Remove( ContactItem contact )
        {
            if (contact == null)
                throw new Exception("Contact cannot be null");

            _contacts.Remove(contact);
        }
    }
}
