using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;
using Newtonsoft.Json;

namespace AddressBook
{
    internal class AddressBookFile
    {
        public void WriteAddressBookToFile(addressbook Addressbook)
        {
            string Path = @"G:\Dot net\repos\AddressBook\AddressBook.txt";
            using (FileStream fs = new FileStream(Path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    foreach (var contact in Addressbook.con)
                    {
                        writer.WriteLine($"{contact.Firstname},{contact.Lastname},{contact.Address},{contact.City},{contact.State},{contact.Zip},{contact.Phonenumber},{contact.email}");
                    }
                }
            }
            Console.WriteLine("Address book written to file successfully.");
        }
        public void CreateCsv(addressbook Addressbook)
        {
            string Path1 = @"G:\Dot net\repos\AddressBook\AddressBook.csv";
            using (FileStream fs = new FileStream(Path1, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    using (CsvWriter cs = new CsvWriter(sw, CultureInfo.InvariantCulture))
                    {
                        cs.WriteHeader<Contact>();
                        foreach (var c in Addressbook.con)
                        {
                            cs.WriteRecord(c);
                        }
                        
                    }

                }
            }
            Console.WriteLine("Address book written to csv file successfully.");
        }
        public void AddToJSONFile(addressbook Addressbook)
        {
            string Path = @"G:\Dot net\repos\AddressBook\AddressBook.jason";
            
            using (StreamWriter writer = new StreamWriter(Path))
            {
                    JsonSerializer serializer = new JsonSerializer();
                    using (JsonWriter jsonWriter = new JsonTextWriter(writer))
                    {
                        serializer.Serialize(jsonWriter, Addressbook.con);
                    }

            }
            
            Console.WriteLine("Address book written to jason file successfully.");
        }

    }
}
