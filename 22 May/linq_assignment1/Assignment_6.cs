/* 
 Exercise 6: LINQ – First Names Starting with a Vowel
 Problem:
 Filter names that start with a vowel.
 Instructions:
 1. Create a 
List<string> with 8–10 names.
 2. Use LINQ to find names starting with vowels (A, E, I, O, U).
 3. Print the result.
 Tips:
 Use 
Where() , 
Prefer 
OrderByDescending() , 
GroupBy() , 
Count() ,  
Average(), 
var when writing LINQ queries for readability
 Keep classes short and to-the-poin
*/ 

using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "John", "Jane", "Alice", "Bob", "Charlie",
                "David", "Eve", "Frank", "Grace", "Helen"
            };

            var vowelNames = names
                .Where(n => "AEIOU".Contains(char.ToUpper(n[0])))
                .OrderByDescending(n => n);

            Console.WriteLine("Names starting with a vowel:");
            foreach (string name in vowelNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
