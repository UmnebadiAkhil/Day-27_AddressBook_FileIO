using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_FileIO
{
    internal class Contact
    {

        //list is created to store contact info
        List<Contact> contacts = new List<Contact>();

        //variables
        public string first_name;
        public string last_name;
        public string address;
        public string city;
        public string state;
        public int zip;
        public long phone;
        public string email;

        
        public Contact()
        {

        }

        
        public Contact(string first_name, string last_name, string address, string city, string state, int zip, long phone, string email)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
            this.email = email;
        }

       
        public void setContacts(List<Contact> contacts)
        {
            this.contacts = contacts;
        }

        
        public List<Contact> getContacts()
        {
            return contacts;
        }

        
        public List<Contact> showContacts()
        {
            return contacts;
        }

        
        public override string ToString()
        {
            return "First Name: " + first_name + " \n" + "Last Name: " + last_name + " \n" + "Address: " + address + " \n" + "City: " + city + " \n" + "State: " + state + " \n" + "Zip: " + zip +" \n" + "Phone Number: " + phone + " \n" + "Email-id: " + email;
        }

    }
}
