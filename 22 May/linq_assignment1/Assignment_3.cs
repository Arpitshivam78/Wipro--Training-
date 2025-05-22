/* 
 Exercise 3: LINQ – Count Students Above Average
 Problem:
 Use LINQ to count how many students scored above the average.
 Instructions:
 1. Create a 
Student class with 
Name , 
Marks .
 2. Add at least 5 students.
 3. Calculate average marks using LINQ: 
.Average()
 4. Use LINQ to count how many students scored above average
*/ 

using System;
using System.Collections.Generic; 

namespace Assignment_3
{ 
    class Student
    { 
        public string Name { get; set; } 
        public int Marks { get; set; } 
    } 

    class Program
    { 
        static void Main(string[] args)
        { 
            List<Student> students = new List<Student>()
            {
                new Student { Name = "Alice", Marks = 85 },
                new Student { Name = "Bob", Marks = 92 },
                new Student { Name = "Charlie", Marks = 78 },
                new Student { Name = "David", Marks = 95 },
                new Student { Name = "Eve", Marks = 88 },
                new Student { Name = "Frank", Marks = 90 }
            };

            var averageMarks = students.Average(s => s.Marks); 

            var aboveAverageCount = students.Count(s => s.Marks > averageMarks); 

            Console.WriteLine($"Number of students above average: {aboveAverageCount}"); 
        } 
    } 
}