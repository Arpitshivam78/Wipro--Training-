/* 
 2. Collection of Objects + LINQ – Student Rank List
 Task:
 Create Student class with Name, Marks, Grade.
 Add 10 students to a List<Student>.
 Use LINQ to:
 Sort by marks (descending)
 Group by grade
 Project the top 3 students using .Take(3
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement
{
    // Define the Student class with properties Name, Marks, and Grade
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Initialize the list of students
            List<Student> students = new List<Student>
            {
                new Student { Name = "A", Marks = 80, Grade = "A" },
                new Student { Name = "B", Marks = 90, Grade = "B" },
                new Student { Name = "C", Marks = 70, Grade = "C" },
                new Student { Name = "D", Marks = 85, Grade = "A" },
                new Student { Name = "E", Marks = 95, Grade = "B" },
                new Student { Name = "F", Marks = 75, Grade = "C" },
                new Student { Name = "G", Marks = 90, Grade = "B" },
                new Student { Name = "H", Marks = 80, Grade = "A" },
                new Student { Name = "I", Marks = 85, Grade = "A" },
                new Student { Name = "J", Marks = 95, Grade = "B" }
            };

            // Display original list
            Console.WriteLine("Original List:");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}, Grade: {student.Grade}");
            }

            // Sort students by Marks in descending order
            var sortedStudents = students.OrderByDescending(s => s.Marks);

            // Display sorted list
            Console.WriteLine("\nSorted List (by Marks Descending):");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}, Grade: {student.Grade}");
            }
        }
    }
}
