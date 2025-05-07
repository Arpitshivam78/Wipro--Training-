using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList Names = new ArrayList();
        Names.Add("Arpit");
        Names.Add("Maya");
        Names.Add("Indrajeet");
        Names.Add("Ram");
        Names.Add("Parshuram");
        
        Names.Remove("Maya");  // Corrected from "Maya :" to "Maya"
        Console.WriteLine("Element is removed. Count: " + Names.Count);

        if (Names.Contains("Arpit"))
        {
            Console.WriteLine("List contains student named Arpit");
        }
        else
        {
            Console.WriteLine("The list doesn't contain student named Arpit");
        }

        foreach (var item in Names)
        {
            Console.WriteLine(item);
        }
    }
}
