﻿namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            addressbook Addressbook = new addressbook();
            AddressBookFile addressBookFile = new AddressBookFile();
           
            while (true)
            {
                Console.WriteLine("select \n1)create contact\n2)display\n3)edit contact\n4)DeleteContactUsingName" +
                    "\n5)search by city or state\n6)view persons by city\n7)view persons by state" +
                    "\n8)get contact count by city\n9)get contact count by state\n10)sort contacts by name" +
                    "\n11)write contact into text file\n12)create csv\n13)add to jason file\n14)convert into all file");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Addressbook.AddContact();
                        break;
                    case 2:
                        Addressbook.Display();
                        break;
                    case 3:
                        Addressbook.Editcontact();
                        break;
                    case 4:
                        Addressbook.DeleteContactUsingName();
                        break;
                    
                    case 5:
                        Console.WriteLine("Enter city or state to search:");
                        string cityOrState = Console.ReadLine();
                        List<Contact> searchResults = Addressbook.SearchByCityOrState(cityOrState);

                        if (searchResults.Count > 0)
                        {
                            Console.WriteLine("Search results:");
                            foreach (var contact in searchResults)
                            {
                                Console.WriteLine("Firstname--" + contact.Firstname);
                                Console.WriteLine("Lastname--" + contact.Lastname);
                                Console.WriteLine("Address--" + contact.Address);
                                Console.WriteLine("City--" + contact.City);
                                Console.WriteLine("State--" + contact.State);
                                Console.WriteLine("Zip--" + contact.Zip);
                                Console.WriteLine("Phonenumber--" + contact.Phonenumber);
                                Console.WriteLine("email--" + contact.email);
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contacts found in the specified city or state.");
                        }

                        break;
                    
                    case 6:
                        Console.WriteLine("Enter city to view contacts:");
                        string city = Console.ReadLine();
                        List<Contact> contactsInCity = Addressbook.GetContactsByCity(city);

                        if (contactsInCity.Count > 0)
                        {
                            Console.WriteLine($"Contacts in {city}:");
                            foreach (var contact in contactsInCity)
                            {
                                Console.WriteLine("Firstname--" + contact.Firstname);
                                Console.WriteLine("Lastname--" + contact.Lastname);
                                Console.WriteLine("Address--" + contact.Address);
                                Console.WriteLine("City--" + contact.City);
                                Console.WriteLine("State--" + contact.State);
                                Console.WriteLine("Zip--" + contact.Zip);
                                Console.WriteLine("Phonenumber--" + contact.Phonenumber);
                                Console.WriteLine("email--" + contact.email);
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contacts found in the specified city.");
                        }

                        break;

                    case 7:
                        Console.WriteLine("Enter state to view contacts:");
                        string state = Console.ReadLine();
                        List<Contact> contactsInState = Addressbook.GetContactsByState(state);

                        if (contactsInState.Count > 0)
                        {
                            Console.WriteLine($"Contacts in {state}:");
                            foreach (var contact in contactsInState)
                            {
                                Console.WriteLine("Firstname--" + contact.Firstname);
                                Console.WriteLine("Lastname--" + contact.Lastname);
                                Console.WriteLine("Address--" + contact.Address);
                                Console.WriteLine("City--" + contact.City);
                                Console.WriteLine("State--" + contact.State);
                                Console.WriteLine("Zip--" + contact.Zip);
                                Console.WriteLine("Phonenumber--" + contact.Phonenumber);
                                Console.WriteLine("email--" + contact.email);
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contacts found in the specified state.");
                        }

                        break;
                    case 8:
                        Console.WriteLine("Enter city to get contact count:");
                        string City = Console.ReadLine();
                        int contactCountByCity = Addressbook.GetContactCountByCity(City);
                        Console.WriteLine($"Contact count in {City}: {contactCountByCity}");
                        break;
                    case 9:  
                        Console.WriteLine("Enter state to get contact count:");
                        string State = Console.ReadLine();
                        int contactCountByState = Addressbook.GetContactCountByState(State);
                        Console.WriteLine($"Contact count in {State}: {contactCountByState}");
                        break;
                    case 10:

                        Addressbook.SortContactsByName();
                        Console.WriteLine("Sorted Contacts:");
                        foreach (var contact in Addressbook.con)
                        {
                            Console.WriteLine(contact);
                        }
                        break;
                    case 11:
                        addressBookFile.WriteAddressBookToFile(Addressbook);
                        break;
                    case 12:
                        addressBookFile.CreateCsv(Addressbook);
                        break;
                    case 13:
                        addressBookFile.AddToJSONFile(Addressbook);
                        break;
                    case 14:
                        addressBookFile.WriteAddressBookToFile(Addressbook);
                        addressBookFile.CreateCsv(Addressbook);
                        addressBookFile.AddToJSONFile(Addressbook);
                        break;
                }
            }

            
            


        }
        
    }
}