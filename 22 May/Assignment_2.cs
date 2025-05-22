/* 
Build a phone book using Dictionary<string, string> .
Instructions:
1. Create a dictionary with name as key and phone number as value.
2. Add 3 contacts.
3. Display all contacts.
4. Ask the user for a name and display the phone number (if found). 
*/ 

using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            contacts.Add("Arpit", "1234567890");
            contacts.Add("Maya", "1234567891");
            contacts.Add("Indrajeet", "1234567892");


            Console.WriteLine("Enter a name to search:");
            string name = Console.ReadLine();

            Console.WriteLine("Phone Book Contacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key}: {contact.Value}");
            }

            if (contacts.ContainsKey(name))
            {
                Console.WriteLine(name + ":" + contacts[name]);
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }
} 

