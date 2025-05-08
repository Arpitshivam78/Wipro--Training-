// Exercise 5: Phone Directory

//Create a Dictionary<string, string> to store names and phone numbers.

// Add 5 contacts.

// Update a phone number for a specific name. I

// Check if a particular name exists.

// Print all the contacts 

using System; 
using System.Collections.Generic; 

class Program 
{ 
    static void Main() 
    { 
        Dictionary<string, string > PhoneDirectory = new Dictionary<string, string>(); 

        PhoneDirectory.Add("Arpit", "1234567890"); 
        PhoneDirectory.Add("Anisha", "1234567880"); 
        PhoneDirectory.Add("Sanskriti", "1234569891"); 
        PhoneDirectory.Add("Amit", "1234567891"); 
        PhoneDirectory.Add("Amitabh", "1234567892"); 

        PhoneDirectory["Amit"] = "9876543210"; 
        Console.WriteLine("Update Amits Contact Number to 9876543210"  + PhoneDirectory["Amit"]); 

        if (PhoneDirectory.ContainsKey("Amit")) 
        { 
            Console.WriteLine("Amit is in the directory"); 
        } 
        else 
        { 
            Console.WriteLine("Amit is not in the directory");  
        }   

        Console.WriteLine("Phone Directory:"); 
                 
    }
}