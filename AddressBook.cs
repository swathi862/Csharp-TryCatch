using System;
using System.Collections.Generic;

namespace addressBook
{
    class AddressBook{

        public Dictionary<String, Contact> DictionaryOfContacts {get; set;} = new Dictionary<String, Contact>();

        public void AddContact(Contact contact){
            DictionaryOfContacts.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email){
            return DictionaryOfContacts[email];
        }
    }
}