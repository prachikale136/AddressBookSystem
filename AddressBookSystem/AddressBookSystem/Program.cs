using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the address Book System Problem");
            AddressBookMain addressBookMain = new AddressBookMain();
            string path = @"D:\RFP-287\Assignment\AddressBookSystem\AddressBookSystem\AddressBookSystem\File.txt";
            PersonContactfile personContactfile = new PersonContactfile();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1 For Add Contact \n2. for print contact \n3. edit Contact \n4. Print edited contact \n5. for deletete contact \n6. Add multiple contact \n7. for Create Dictionary \n8. for display dictionary \n9. for check duplicates \n10. search \n11.view person \n12. count contact \n13. sort peron by name \n14. sort by zip,state and city \n15.Read contact from file \n16. Write contact into file \n17. exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                List<Contact> ContactList = null;
                switch (choice)
                {
                    case 1:
                        addressBookMain.AddContact();
                        break;
                    case 2:
                        addressBookMain.PrintList();
                        break;
                    case 3:
                       
                        addressBookMain.Edit();
                        break;
                    case 4:
                        addressBookMain.PrintEditContact();
                        break;
                    case 5:
                        addressBookMain.DeleteContact();
                        break;
                    case 6:
                        addressBookMain.AddMultipleContact();
                        break;
                    case 7:
                        addressBookMain.CreateDictionary();
                        break;
                    case 8:
                        addressBookMain.DisplayDicttionaryList();
                        break;
                    case 9:
                      addressBookMain.CheckDuplicates();    
                        break;
                    case 10:
                        addressBookMain.Search();
                        break;
                    case 11:
                        addressBookMain.ViewContact();
                        break;
                    case 12:
                        addressBookMain.CountContact();
                        break;
                    case 13:
                        addressBookMain.SortByPersonName();
                        break;
                    case 14:
                        addressBookMain.SortContactByCity_State_ZipCode();
                        break;
                    case 15:
                        addressBookMain.ReadContactFromFile(ContactList);
                        break;
                    case 16:
                        addressBookMain.WriteContactIntoFile(ContactList);
                        break;
                    default:
                        flag= false;
                        break;



                }




            }

        }
    }
}


