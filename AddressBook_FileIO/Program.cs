
using System;
using System.Collections.Generic;

namespace AddressBook_FileIO
{
    class Program
    {
       
        AddressBook book;

        public Program()
        {
            book = new AddressBook();
        }

        
        static void Main(string[] args)
        {
            
            Program p = new Program();
           
            Console.WriteLine("Hello, Welcome to Address Book!");
           
            Console.WriteLine("Select the option. \n1. Add new contact. \n2. Exit.");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the person details to be added in the address book");
                    Console.WriteLine("First Name");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("Last Name");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Address");
                    string Address = Console.ReadLine();
                    Console.WriteLine("City");
                    string City = Console.ReadLine();
                    Console.WriteLine("State");
                    string State = Console.ReadLine();
                    Console.WriteLine("Zip code");
                    string ZipCode = Console.ReadLine();
                    Console.WriteLine("Phone Number");
                    string PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Email");
                    string Email = Console.ReadLine();
                    //calling AddContact function
                    if (p.book.AddContact(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email))
                    {
                        Console.WriteLine("Contact added successfully");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Contact already exists");
                        break;
                    }
            }
        }
    }
}
