using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> employee = new Dictionary<int, string>
        {
            {1, "John"},
            {2, "Jane"},
            {3, "Sam"}
        };

        employee[2] = "Janet"; // Updating value for key 2

        Console.WriteLine("Updated list is:");

        foreach (var emp in employee)
        {
            Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");
        }
    }
}
