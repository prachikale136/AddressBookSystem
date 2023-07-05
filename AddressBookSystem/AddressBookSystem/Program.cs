using System;
using System.Collections.Generic;
using System.Linq;
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
            
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1 For Add Contact \n2. for print contact \n3. edit Contact \n4. Print edited contact \n5. for deletete contact \n6. Add multiple contact \n7. for Create Dictionary \n8. for display dictionary \n9. exit");
                int choice = Convert.ToInt32(Console.ReadLine());
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
                    default:
                        flag= false;
                        break;



                }




            }

        }
    }
}


