/* 
Problem:
Count how many times each word appears in a sentence.
Instructions:
1. Input a sentence like: "C# is great and C# is fun"
2. Split it into words.
3. Use LINQ group by and count .
4. Print:
C#: 2
is: 2
great: 1
and: 1
fun: 1 
*/

using System;
using Systeem.Collections.Generic;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        { 
            string sentence = "C# is great and C# is fun"; 
            string[] words = sentence.ToLower().Split(' '); 
            var groupedWords = words.GroupBy(w => w).Select(g => new { Word = g.Key, Count = g.Count() }); 
            foreach (var word in groupedWords) 
            { 
                Console.WriteLine($"{word.Word}: {word.Count}"); 
            }
        }
    }
}