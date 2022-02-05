﻿
using System;
using System.Collections.Generic;
using System.Text;


namespace AddressBook_FileIO
{
    public class AddressBook
    {

        public HashSet<Contact> People;

        public AddressBook()
        {
            People = new HashSet<Contact>();
        }

        public Contact FindContact(string fname)
        {
            Contact contact = null;
            
            foreach (var person in People)
            {
                if (person.FirstName.Equals(fname))
                {
                    contact = person;
                    break;
                }
            }
            return contact;
        }

        public bool AddContact(string FirstName, string LastName, string Address, string City, string State, string ZipCode, string PhoneNumber, string Email)
        {
            Contact contact = new Contact(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);

            Contact result = FindContact(FirstName);

            if (result == null)
            {
                People.Add(contact);
                return true;
            }
            else
                return false;
        }

        public bool RemoveContact(string name)
        {
            
            Contact c = FindContact(name);

            if (c != null)
            {
                People.Remove(c);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
