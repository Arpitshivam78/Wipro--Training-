using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> cities = new Dictionary<string, string>
        {
            { "Maharashtra,Mumbai", "Maharashtra" },
            { "Karnataka,Bangalore", "Karnataka" },
            { "Tamil Nadu,Chennai", "Tamil Nadu" },
            { "Telangana,Hyderabad", "Telangana" },
            { "Andhra Pradesh,Amaravati", "Andhra Pradesh" }
        
        };

        Console.WriteLine("Indian Cities and their States :");

        foreach (var city in cities)
        {
            Console.WriteLine($"ID: {city.Key}, Name: {city.Value}");
        } 

        if (cities.ContainsKey("Chennai"))
        { 
           Console.WriteLine("Chennai is present in the list."); 
        }
    }
}
