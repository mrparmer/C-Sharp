using System;


namespace SimpleContacts
{
    class Contact
    {
        private string name, phone, address, email, comment, contact;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set// { phone = value; }
            {
                if (value.Length == 10)
                {
                    phone = value;
                }
                else
                {
                    phone = "0000000000";
                }
            }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        public string LastContact
        {
            get { return contact; }
            set { contact = value; }
        }

        public void Contacts()
        {
            Name = "John Doe";
            Phone = "0000000000";
            Address = "123 Main St";
            Email = "johndoe@google.com";
            Comment = "Test Contact";
            LastContact = "1/1/2019";
        }

        public void Contacts(string name, string phone, string address, string email, string comment, string contact)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Email = email;
            Comment = comment;
            LastContact = contact;            
        }

        public override string ToString()
        {
            string output = String.Empty;
            output += String.Format("{0}; ", Name);
            output += String.Format("({0}) {1}-{2} ", Phone.Substring(0,3), Phone.Substring(3,3), Phone.Substring(6,4));
            output += String.Format("; {0}; {1}; {2}", Email, Comment, LastContact);

            //{ 0};Name, Phone, Address,
            //{ 1};
            //{ 2};
            return output;
        }


    }
}
