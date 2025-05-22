/* 
 Exercise 5: Grouping with LINQ – Group Employees by Department 

 Group employees by department.
Instructions:
1. Create an Employee class with Name , Department .
2. Add 6 employees (across 2–3 departments).
3. Use LINQ group by to group them.
4. Print employees under each department. 
*/ 

using System;
using System.Collections.Generic;

namespace Assignment_5
{
    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Name = "Alice", Department = "HR" },
                new Employee { Name = "Bob", Department = "IT" },
                new Employee { Name = "Charlie", Department = "HR" },
                new Employee { Name = "David", Department = "IT" },
                new Employee { Name = "Eve", Department = "HR" },
                new Employee { Name = "Frank", Department = "IT" }
            };

            var groupedEmployees = employees.GroupBy(e => e.Department); 
            
            foreach (var group in groupedEmployees)
            { 
                Console.WriteLine($"Department: {group.Key}"); 
                foreach (var employee in group) 
                { 
                    Console.WriteLine($"- {employee.Name}"); 
                } 
            }
        } 
        
    }
}