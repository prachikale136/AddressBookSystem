﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        Contact contact = new Contact(); // Contact contact = new Contact(); 
        public List<Contact> contactList = new List<Contact>();  //here create a list for contact
        public void AddContact()
        {
           

            // calling variables by using object
            Console.WriteLine("Enter the first Name");
            contact.firstName = Console.ReadLine();

            Console.WriteLine("Ente rthe last name");
            contact.lastName = Console.ReadLine();

            Console.WriteLine("Enter the address");
            contact.address = Console.ReadLine();

            Console.WriteLine("Enter the city");
            contact.city = Console.ReadLine();

            Console.WriteLine("Enter the state");
            contact.state = Console.ReadLine();

            Console.Write("Enter Zip Code  : ");
            contact.zip = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Phone Number: ");
            contact.phoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Email Address: ");
            contact.email = Console.ReadLine();

            contactList.Add(contact);

        }

        //method to print Conatct List

        public void PrintList()
        {
            foreach (Contact contact in contactList)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("First Name :" + contact.firstName);
                Console.WriteLine("LastNAme:" + contact.lastName);
                Console.WriteLine("Address:" + contact.address);
                Console.WriteLine("City:" + contact.city);
                Console.WriteLine("State:" + contact.state);
                Console.WriteLine("zip:" + contact.zip);
                Console.WriteLine("PhoneNumber:" + contact.phoneNumber);
                Console.WriteLine("Email" + contact.email);

            }

        }
        //method for EditContact
        public void Edit()
        {
            Console.WriteLine("Enter the first name to be edited");
            string fname = Console.ReadLine();
            Console.WriteLine("Enetr the last name to be edited");
            string lname = Console.ReadLine();            
            if (contact.firstName == fname && contact.lastName == lname)
                {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Enter 1 for edit First Name");
                Console.WriteLine("Enter 2 for edit Last Name");
                Console.WriteLine("Enter 3 for edit Address");
                Console.WriteLine("Enter 4 for edit City");
                Console.WriteLine("Enter 5 for edit State");
                Console.WriteLine("Enter 6 for edit zip Code");
                Console.WriteLine("Enter 7 for edit Phone number");
                Console.WriteLine("Enetr 8 for edit Email");
                Console.WriteLine("Enter 9 if you are with editing");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        Console.WriteLine("Enter new name ");
                        string fName = Console.ReadLine();
                        contact.firstName = fName;
                        break;
                    case 2:
                        Console.WriteLine("Enter new last name");
                        string lName = Console.ReadLine();
                        contact.lastName = lName;
                        break;
                    case 3:
                        Console.WriteLine("ENter new Address");
                        string address = Console.ReadLine();
                        contact.address = address;
                        break;
                    case 4:
                        Console.WriteLine("Enetr new city");
                        string city = Console.ReadLine();
                        contact.city = city;
                        break;
                    case 5:
                        Console.WriteLine("Enter new state");
                        string state = Console.ReadLine();
                        contact.state = state;
                        break;
                    case 6:
                        Console.WriteLine("Enter new zip");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        contact.zip = zip;
                        break;
                    case 7:
                        Console.WriteLine("Enetr new phone number");
                        long phoneNumber = Convert.ToInt64(Console.ReadLine());
                        contact.phoneNumber = phoneNumber;
                        break;
                    case 8:
                        Console.WriteLine("Enter new emailid");
                        string email = Console.ReadLine();
                        contact.email = email;
                        break;
                }

            }
            else
            {
                Console.WriteLine("Name does not exist");
            }
        }

       

        public void PrintEditContact()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("First Name :" + " " + contact.firstName);
            Console.WriteLine("LastNAme:" + " " + contact.lastName);
            Console.WriteLine("Address:" + " " + contact.address);
            Console.WriteLine("City:" + " " + contact.city);
            Console.WriteLine("State:" + " " + contact.state);
            Console.WriteLine("zip:" + " " + contact.zip);
            Console.WriteLine("PhoneNumber:" + " " + contact.phoneNumber);
            Console.WriteLine("Email:" + " " + contact.email);

        }
        // method for delete contact
        public void DeleteContact()
        {
            Contact deletedContact = null;
            Console.WriteLine("Enter the first name to be delete");
            string fname = Console.ReadLine();
            foreach(Contact contact in contactList)
            {
                if (contact.firstName == fname)
                {
                    deletedContact = contact;
                    this.contactList.Remove(contact);
                    break;
                }
                else
                {
                    Console.WriteLine("NAme doesnt exist");
                }
            }
        }

        public void AddMultipleContact()
        {
            Console.WriteLine("Enetr how many contact you want to add");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                   AddContact();

            }

        }

    }
}