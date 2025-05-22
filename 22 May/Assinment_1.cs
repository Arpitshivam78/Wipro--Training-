/* 
Collections + LINQ
exercise 1: Working with List – Student Names
Store and display student names using a List<string> .
Instructions:
1. Create a List<string> called students .
2. Add 5 names to the list.
3. Display all names using a foreach loop.
4. Sort the list and display it again. 

*/

using System;
using System.Collections.Generic;

namespace Assignment_1
{
    class Program
    {
        static List<string> studentName = new List<string>();

        static void Main(string[] args)
        {
            studentName.Add("Arpit");
            studentName.Add("Akriti");
            studentName.Add("Sumit");
            studentName.Add("Maya");
            studentName.Add("Indrajeet");

            Console.WriteLine("Original List:");
            foreach (string name in studentName)
            {
                Console.WriteLine(name);
            }

            Display();
        }

        static void Display()
        {
            studentName.Sort();
            Console.WriteLine("\nSorted List:");
            foreach (string name in studentName)
            {
                Console.WriteLine(name);
            }
        }
    }
}
