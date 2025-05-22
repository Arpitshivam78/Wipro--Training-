/* 
 Exercise 4: LINQ – Find Duplicate Numbers
 Problem:
 Identify duplicates in a list of numbers.
 Instructions:
 1. Create a 
List<int> with some repeated numbers.
 2. Use LINQ to find numbers that appear more than once.
 3. Print the duplicated numbers.
*/ 

using System;
using System.Collections.Generic; 

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var duplicates = numbers.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key);
            Console.WriteLine("Duplicate numbers:");
            foreach (int number in duplicates)
            {
                Console.WriteLine(number);
            }
        } 
         
    } 
}