using AddressBook_Collections;
using System;
using System.Collections.Generic;

namespace Day_13_AddressBook
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            
            Dictionary<String, List<Contact>> sorted = new Dictionary<String, List<Contact>>();
            int c1 = 0;
            while (c1 != 6)
            {
                string? bname = " ";
                Console.WriteLine("Hello, Welcome to Address Book!");
                //stores Contact list for different address books
                List<Contact> gContact = new List<Contact>();
                Console.WriteLine("1. Add Address Book: ");
                Console.WriteLine("2. Edit a Particular Address Book: ");
                Console.WriteLine("3. Display Address Book: ");
                Console.WriteLine("4. View Person's Details By City: ");
                Console.WriteLine("5. View Person's Details By State: ");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice: ");
                c1 = Convert.ToInt32(Console.ReadLine());
                switch (c1)
                {
                    case 1:
                        Console.WriteLine("Enter the name of Address Book: ");
                        bname = Console.ReadLine();
                        //stores Contact list for a particular book
                        List<Contact> Contact = new List<Contact>();

                        Program.edit_data(Contact);

                        gContact.AddRange(Contact);
                        sorted.Add(bname, gContact);
                        break;

                    case 2:
                        Console.WriteLine("Enter the name of Address Book: ");
                        string? bname1 = Console.ReadLine();
                        if (sorted.ContainsKey(bname1))
                        {
                            List<Contact> edit = sorted[bname1];
                            Program.edit_data(edit);
                        }
                        else
                        {
                            Console.WriteLine("Mentioned Address Book is not there");
                        }
                        break;

                    case 3:
                        foreach (KeyValuePair<String, List<Contact>> kv in sorted)
                        {
                            string a = kv.Key;
                            List<Contact> list1 = (List<Contact>)kv.Value;
                            Console.WriteLine("Address Book Name: " + a);
                            foreach (Contact c in list1)
                            {
                                Console.WriteLine(c);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter the city: ");
                        string? city = Console.ReadLine();

                        Dictionary<string, List<Contact>> cty = new Dictionary<string, List<Contact>>();
                        List<Contact> gtemp = new List<Contact>();

                        foreach (KeyValuePair<string, List<Contact>> kv in sorted)
                        {
                            //gives list details per address book
                            List<Contact> list1 = kv.Value;
                            List<Contact> temp = new List<Contact>();
                            foreach (Contact c in list1)
                            {
                                if (c.city.ToLower().Equals(city.ToLower()))
                                {
                                    temp.Add(c);
                                }
                            }
                            //Appends person's details per book by city       
                            gtemp.AddRange(temp);
                        }
                        cty.Add(city, gtemp);

                        foreach (KeyValuePair<string, List<Contact>> kv in cty)
                        {
                            string a = kv.Key;
                            List<Contact> lst = kv.Value;
                            Console.WriteLine("City Name: " + a);
                            foreach (Contact c in lst)
                            {
                                Console.WriteLine(c);
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter the State Name: ");
                        string? state = Console.ReadLine();
                        int flag1 = 0;

                        Dictionary<string, List<Contact>> st = new Dictionary<string, List<Contact>>();
                        //gtemp1 is created to store person details per state
                        List<Contact> gtemp1 = new List<Contact>();

                        foreach (KeyValuePair<string, List<Contact>> kv in sorted)
                        {
                            List<Contact> list1 = kv.Value;
                            List<Contact> temp = new List<Contact>();
                            foreach (Contact c in list1)
                            {
                                if (c.state.ToLower().Equals(state.ToLower()))
                                {
                                    temp.Add(c);
                                    flag1 = 1;
                                }
                            }
                            //Appends person's details per book by state   
                            gtemp1.AddRange(temp);
                        }
                        st.Add(state, gtemp1);

                        if (flag1 == 0)
                        {
                            Console.WriteLine("Mentioned State Name isn't present in Address Book");
                        }
                        else
                        {
                            foreach (KeyValuePair<string, List<Contact>> kv in st)
                            {
                                string a = kv.Key;
                                List<Contact> lst = kv.Value;
                                Console.WriteLine("City Name: " + a);
                                foreach (Contact c in lst)
                                {
                                    Console.WriteLine(c);
                                }
                            }
                        }
                        break;
                    case 6:
                        break;
                }
            }
        }

        
        public static void edit_data(List<Contact> Contact)
        {
            int choice = 0;
            string bname = " ";
            while (choice != 5)
            {
                //here contact obj is stored temporarily, changes when edited and deleted
                List<Contact> list = new List<Contact>();
                Console.WriteLine("\t********Main Menu***********\t");
                Console.WriteLine("Enter the following choice");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Display Contact");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add New Contact: ");
                        Console.WriteLine("Enter the firstname: ");
                        string? first_name = Console.ReadLine();
                        Console.WriteLine("Enter the lastname: ");
                        string? last_name = Console.ReadLine();
                        Console.WriteLine("Enter the address: ");
                        string? address = Console.ReadLine();
                        Console.WriteLine("Enter the city: ");
                        string? city = Console.ReadLine();
                        Console.WriteLine("Enter the state: ");
                        string? state = Console.ReadLine();
                        Console.WriteLine("Enter the zip: ");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the phone number");
                        long phone = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter the email: ");
                        string? email = Console.ReadLine();

                        Contact ct1 = new Contact(first_name, last_name, address, city, state, zip, phone, email);
                        list.Add(ct1);
                        Console.WriteLine("Contact Added Successfully");
                        break;

                    case 2:
                        Console.WriteLine("Enter the first name of the person: ");
                        string? first = Console.ReadLine();
                        foreach (Contact c in Contact)
                        {
                            if (c.first_name.Equals(first))
                            {
                                int n = 0;
                                while (n != 9)
                                {
                                    Console.WriteLine("Enter the following choice");
                                    Console.WriteLine("1. Edit First Name");
                                    Console.WriteLine("2. Edit Last Name");
                                    Console.WriteLine("3. Edit Address");
                                    Console.WriteLine("4. Edit City");
                                    Console.WriteLine("5. Edit State");
                                    Console.WriteLine("6. Edit Zip");
                                    Console.WriteLine("7. Edit Phone Number");
                                    Console.WriteLine("8. Edit E-mail");
                                    Console.WriteLine("9. Exit");
                                    Console.WriteLine("Enter your choice: ");
                                    n = Convert.ToInt32(Console.ReadLine());

                                    switch (n)
                                    {
                                        case 1:
                                            Console.WriteLine("1. Edit First Name");
                                            string? fname = Console.ReadLine();
                                            c.first_name = fname;
                                            Console.WriteLine("Edited Successfully");
                                            break;
                                        case 2:
                                            Console.WriteLine("1. Edit Last Name");
                                            string? lname = Console.ReadLine();
                                            c.last_name = lname;
                                            Console.WriteLine("Edited Successfully");
                                            break;
                                        case 3:
                                            Console.WriteLine("1. Edit Address Name");
                                            string? adrss = Console.ReadLine();
                                            c.address = adrss;
                                            Console.WriteLine("Edited Successfully");
                                            break;
                                        case 4:
                                            Console.WriteLine("1. Edit City Name");
                                            string? cty = Console.ReadLine();
                                            c.city = cty;
                                            Console.WriteLine("Edited Successfully");
                                            break;
                                        case 5:
                                            Console.WriteLine("1. Edit State");
                                            string? ste = Console.ReadLine();
                                            c.state = ste;
                                            Console.WriteLine("Edited Successfully");
                                            break;
                                        case 6:
                                            Console.WriteLine("1. Edit Zip");
                                            int zp = Convert.ToInt32(Console.ReadLine());
                                            c.zip = zp;
                                            Console.WriteLine("Edited Successfully");
                                            break;
                                        case 7:
                                            Console.WriteLine("1. Edit Phone Number");
                                            long no = Convert.ToInt64(Console.ReadLine());
                                            c.phone = no;
                                            Console.WriteLine("Edited Successfully");
                                            break;
                                        case 8:
                                            Console.WriteLine("1. Edit Email");
                                            string? mail = Console.ReadLine();
                                            c.first_name = mail;
                                            Console.WriteLine("Edited Successfully");
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Enter a valid name");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter the phone number of the person: ");
                        string? fst = Console.ReadLine();
                        List<Contact> lst = new List<Contact>();
                        foreach (Contact c in Contact)
                        {
                            if (c.phone.Equals(fst))
                            {
                                lst.Add(c);  
                            }
                        }
                        Contact.RemoveAll(i => lst.Contains(i));
                        Console.WriteLine("Contact Deleted Successfully");
                        break;

                    case 4:
                        foreach (Contact c in Contact)
                        {
                            Console.WriteLine(c);
                        }
                        break;
                    case 5:
                        break;
                }
                                Contact.AddRange(list);
            }
        }
    }
}
