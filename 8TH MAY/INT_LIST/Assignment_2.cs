// 1. ArrayList Exercises

//Exercise 1: Manage Student Names

//Create an ArrayList to store student names.

///Add 5 names to the list.

//Remove a specific name by value.

//Display the list of names after removal.

//Check if a name exists in the list.


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> studentName = new List<string>();

        studentName.Add("Arpit");
        studentName.Add("Amit");
        studentName.Add("Amrit");
        studentName.Add("Amitabh");
        studentName.Add("Rekha");

        studentName.Remove("Amit"); 

        Console.WriteLine("List of names after removal:");
        foreach (string name in studentName)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("List Contains Amit: " + studentName.Contains("Amit"));

        foreach (string name in studentName)
        {
            Console.WriteLine(name);
        }
    }
}
