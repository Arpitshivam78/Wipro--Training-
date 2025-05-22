/* 
 Exercise 1: List – Even & Odd Numbers
Separate even and odd numbers from a list.
Instructions:
1. Create a List<int> with at least 10 numbers.
2. Use LINQ to filter:
One list with even numbers
One list with odd numbers
3. Print both lists.

*/ 

using System;
using System.Collections.Generic; 

namespace Assignment_1
{ 
    class Program
    { 
        static void Main(string[] args)
        { 
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList(); 
            List<int> oddNumbers = numbers.Where(n => n % 2 != 0).ToList(); 
            Console.WriteLine("Even numbers:"); 
            foreach (int number in evenNumbers) 
            { 
                Console.WriteLine(number); 
            } 
            Console.WriteLine("Odd numbers:"); 
            foreach (int number in oddNumbers) 
            { 
                Console.WriteLine(number); 
            } 
        } 
    } 
}
