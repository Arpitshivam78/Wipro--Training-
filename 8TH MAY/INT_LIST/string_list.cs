using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>();

        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");

        fruits.Remove("Banana");   // Removes "Banana"
        fruits.RemoveAt(0);        // Removes "Apple"
        fruits.Clear();            // Clears the list

        fruits.Add("Mango");       // Adds "Mango"
        fruits.Sort();             // Sorts the list (though only one item here)

        foreach (string fruit in fruits)   // Changed loop variable name
        {
            Console.WriteLine(fruit);
        }
    }
}
