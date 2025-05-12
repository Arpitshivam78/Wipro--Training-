using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "John", "Jane", "Jack", "Jill", "James" };
        UsingAnonymousMethods(names);
    }

    private static void UsingAnonymousMethods(string[] names)
    {
        // Define an anonymous method for filtering strings with length 5
        Func<string, bool> filter = delegate (string s)
        {
            // More lines of code can go here if needed
            return s.Length == 5;
        };

        // Define an anonymous method for extracting the string (identity function)
        Func<string, string> extract = delegate (string s)
        {
            return s;
        };

        // Define an anonymous method for projecting the string to uppercase
        Func<string, string> project = delegate (string s)
        {
            return s.ToUpper();
        };

        // Use LINQ's Where extension method with the filter delegate
        IEnumerable<string> query = names.Where(filter);

        foreach (string item in query)
        {
            Console.WriteLine(item);
        }
    }
} 

