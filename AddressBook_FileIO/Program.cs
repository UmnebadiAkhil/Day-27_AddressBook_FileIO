
using AddressBook_Collections;
using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            int choice = 0;
            while (choice != 2)
            {
               
                List<Contact> list = new List<Contact>();
                Console.WriteLine("\n\t********Main Menu***********\t\n");
                Console.WriteLine("Enter the following choice");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n Add New Contact: \n");
                        Console.WriteLine("Enter the firstname: ");
                        string first_name = Console.ReadLine().ToUpper();
                        Console.WriteLine("Enter the lastname: ");
                        string last_name = Console.ReadLine().ToUpper();
                        Console.WriteLine("Enter the address: ");
                        string address = Console.ReadLine().ToUpper();
                        Console.WriteLine("Enter the city: ");
                        string city = Console.ReadLine().ToUpper();
                        Console.WriteLine("Enter the state: ");
                        string state = Console.ReadLine().ToUpper();
                        Console.WriteLine("Enter the zip: ");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the phone number");
                        long phone = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter the email: ");
                        string email = Console.ReadLine().ToLower();

                        Contact ct1 = new Contact(first_name, last_name, address, city, state, zip, phone, email);
                        list.Add(ct1);
                        Console.WriteLine("Contact Added Successfully");
                        break;
                    case 2:
                        break;

                }
            }
        }
    }
}
