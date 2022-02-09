using CsvHelper;
using Newtonsoft.Json;
using System.Globalization;
namespace AddressBook_FileIO
{
    public class ReadWrite
    {

        public static void ReadFromStreamReader()
        {
            string path = @"C:\Users\admin\source\repos\Day-20-AddressBook\Day-20-AddressBook\Utility\Contacts.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    String fileData = " ";
                    while ((fileData = sr.ReadLine()) != null)
                        Console.WriteLine((fileData));
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }

        public static void WriteUsingStreamWriter(List<Contact> data)
        {
            string path = @"C:\Users\admin\source\repos\Day-20-AddressBook\Day-20-AddressBook\Utility\Contacts.txt";
            if (File.Exists(path))
            {
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    foreach (Contact contact in data)
                    {
                        streamWriter.WriteLine(contact.FirstName + "\t" + contact.LastName + "\t" + contact.Address + "\t" + contact.City + "\t" + contact.State + "\t" + contact.ZipCode + "\t" + contact.PhoneNumber + "\t" + contact.Email);
                    }
                    streamWriter.Close();
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }

        public static void ImplementCSVDataHandling()
        {
            string filePath = @"C:\Users\akhil\OneDrive\Desktop\TerminalCommands\RFP\Day-27_AddressBook_FileIO\AddressBook_FileIO\Utility\Contact.csv";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("Data Reading done successfully from Contact.csv file");
                foreach (Contact contact in records)
                {
                    Console.Write("\t" + contact.FirstName);
                    Console.Write("\t" + contact.LastName);
                    Console.Write("\t" + contact.Address);
                    Console.Write("\t" + contact.City);
                    Console.Write("\t" + contact.State);
                    Console.Write("\t" + contact.ZipCode);
                    Console.Write("\t" + contact.PhoneNumber);
                    Console.Write("\t" + contact.Email);
                    Console.Write("\n");
                }
            }
        }
        public static void WriteCSVFile(List<Contact> data)
        {
            string filePath = @"C:\Users\akhil\OneDrive\Desktop\TerminalCommands\RFP\Day-27_AddressBook_FileIO\AddressBook_FileIO\Utility\Contact.csv";
            using (var writer = new StreamWriter(filePath))
            using (var csvWrite = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                Console.WriteLine("Data Writing done successfully from Contact.csv file");
                csvWrite.WriteRecords(data);
            }
        }
        public static void ReadJsonFile()
        {
            string filePath = @"C:\Users\akhil\OneDrive\Desktop\TerminalCommands\RFP\Day-27_AddressBook_FileIO\AddressBook_FileIO\Contacts.json";
            if (File.Exists(filePath))
            {
                IList<Contact> contactsRead = JsonConvert.DeserializeObject<IList<Contact>>(File.ReadAllText(filePath));
                foreach (Contact contact in contactsRead)
                {
                    Console.Write("\t" + contact.FirstName);
                    Console.Write("\t" + contact.LastName);
                    Console.Write("\t" + contact.Address);
                    Console.Write("\t" + contact.City);
                    Console.Write("\t" + contact.State);
                    Console.Write("\t" + contact.ZipCode);
                    Console.Write("\t" + contact.PhoneNumber);
                    Console.Write("\t" + contact.Email);
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("File exists!");
            }
        }
        public static void WriteToJsonFile(List<Contact> data)
        {
            string filePath = @"C:\Users\akhil\OneDrive\Desktop\TerminalCommands\RFP\Day-27_AddressBook_FileIO\AddressBook_FileIO\Contacts.json";
            if (File.Exists(filePath))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                using (JsonWriter writer = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(writer, data);
                }
            }
            else
            {
                Console.WriteLine("File exists!");
            }
        }
    }
}


