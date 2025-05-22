/* 
Problem:
Find top 3 scoring students using LINQ.
Instructions:
1. Create a Student class with Name , Marks .
2. Add 6 students to a list.
3. Use LINQ to get the top 3 by Marks.
4. Print the result. 
*/ 

using System;
using System.Collections.Generic; 

namespace Assignment_4
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

            var topStudents = students.OrderByDescending(s => s.Marks).Take(3); 

            foreach (var student in topStudents)
            { 
                Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}"); 
            } 
        } 
    } 
} 