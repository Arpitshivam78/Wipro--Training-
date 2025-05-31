/* 
 10. Student Gradebook with LINQ + Collections
 Concepts: Dictionary, List, LINQ Task:
 Accept marks of students in multiple subjects
 Calculate average, highest, and lowest per student
 Find top 3 scorers using LINQ
*/ 

using System;
using System.Collections.Generic;
using System.Linq;

static void Main(string[] args)
{
    
    Dictionary<string, List<int>> studentMarks = new Dictionary<string, List<int>>(); 

    Console.Write("Enter the number of students: ");
    int numStudents = int.Parse(Console.ReadLine()); 

    for (int i = 1; i <= numStudents; i++)
    {
        Console.WriteLine($"Enter details for student {i}:"); 
        Console.Write("Name: ");
        string name = Console.ReadLine(); 

        List<int> marks = new List<int>(); 

        for (int j = 1; j <= 3; j++)
        {
            Console.Write($"Enter marks for subject {j}: ");
            int mark = int.Parse(Console.ReadLine()); 
            marks.Add(mark); 
        } 

        studentMarks[name] = marks; 
    } 

    foreach (KeyValuePair<string, List<int>> entry in studentMarks)
    {
        string name = entry.Key; 
        List<int> marks = entry.Value; 

        int average = marks.Average(); 
        int highest = marks.Max(); 
        int lowest = marks.Min(); 

        Console.WriteLine($"Average marks for {name}: {average}"); 
        Console.WriteLine($"Highest mark for {name}: {highest}"); 
        Console.WriteLine($"Lowest mark for {name}: {lowest}"); 
    } 

    var topScorers = studentMarks.SelectMany(entry => entry.Value).OrderByDescending(mark => mark).Take(3); 

    Console.WriteLine("Top 3 scorers:"); 
    foreach (int mark in topScorers)
    {
        Console.WriteLine(mark); 
    } 
}