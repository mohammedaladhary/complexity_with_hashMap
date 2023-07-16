namespace complexity
{
    internal class Contacts
    {
        public List<Contact> contacts;
        public string name { get; private set; }


        public Contacts()
        {
            contacts = new List<Contact>();
        }


        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public Contact GetContact(string name)
        {
            foreach (Contact contact in contacts)
            {
                if(contact.Name == name)
                {
                    return contact;
                }
            }
            return null;
        }
    }

    internal class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string Name, string PhoneNumber)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
        }
    }
}