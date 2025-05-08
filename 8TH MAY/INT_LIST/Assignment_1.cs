//Exercise 1: Basic Operations

//1. Create a list of employee names.

//2. Add 5 employees.

//3. Remove an employee by name.

//4. Check if a specific name exists.

//5. Print the total number of employees.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> employees = new List<string>();
        employees.Add("Arpit");
        employees.Add("Akriti");
        employees.Add("Simran");
        employees.Add("Raj");

        employees.Remove("Simran");

        // Check if "Akriti" exists in the list
        if (employees.Contains("Akriti"))
        {
            Console.WriteLine("Employee 'Akriti' exists in the list.");
        }
        else
        {
            Console.WriteLine("Employee 'Akriti' does not exist.");
        }

    
        Console.WriteLine("Total number of employees: " + employees.Count);

        
        Console.WriteLine("Employee List:");
        foreach (string employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}
