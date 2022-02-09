using System.IO;

namespace AddressBook_FileIO
{
    public class ReadWrite
    {
        public static void ReadFromStreamReader()
        {
            string path = @"C:\Users\akhil\OneDrive\Desktop\TerminalCommands\RFP\Day-27_AddressBook_FileIO\AddressBook_FileIO\Sample.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    String fileData = "";
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

        public static void WriteUsingStreamWriter(List<string> data)
        {
            string path = @"C:\Users\akhil\OneDrive\Desktop\TerminalCommands\RFP\Day-27_AddressBook_FileIO\AddressBook_FileIO\Sample.txt";
            if (File.Exists(path))
            {
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    foreach (string contact in data)
                    {
                        streamWriter.WriteLine(contact);
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
    }
}

