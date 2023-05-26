using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class addressbook
    {

        List<Contact> con = new List<Contact>();
        public void AddContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter Firstname");
            contact.Firstname = Console.ReadLine()!;
            Console.WriteLine("Enter Lasttname");
            contact.Lastname = Console.ReadLine()!;
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine()!;
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine()!;
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine()!;
            Console.WriteLine("Enter Zip");
            contact.Zip = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Phonenumber");
            contact.Phonenumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter email");
            contact.email = Console.ReadLine()!;


            con.Add(contact);


        }
        public void Display()
        {
            foreach (var contact in con)
            {
                Console.WriteLine("Firstname--" + contact.Firstname);
                Console.WriteLine("Lastname--" + contact.Lastname);
                Console.WriteLine("Address--" + contact.Address);
                Console.WriteLine("City--" + contact.City);
                Console.WriteLine("State--" + contact.State);
                Console.WriteLine("Zip--" + contact.Zip);
                Console.WriteLine("Phonenumber--" + contact.Phonenumber);
                Console.WriteLine("email--" + contact.email);

            }

        }



    }
}
