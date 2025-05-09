// Exercise 4: Count Unique Elements
// •	Create a List<int> with 10 numbers, including duplicates.
//•	Find and print unique numbers using a HashSet.
//•	Count how many unique elements are present. 

using System; 
using System.Collections.Generic; 

class Program 
{ 
    static void Main() 
    {  
        List<int > numbers = new List<int>() {1,1,2,2,3,4,5}; 

        HashSet<int> uniquenumbers  = new HashSet<int>(numbers); 

        Console.WriteLine("Unique numbers:"); 
        foreach (int number in uniquenumbers) 
        { 
            Console.WriteLine(number); 
        } 

    }
}