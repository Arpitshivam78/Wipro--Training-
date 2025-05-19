using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_2
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create List of Employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { EmployeeID = 1, Name = "Arpit", Salary = 150000 },
                new Employee { EmployeeID = 2, Name = "Akriti", Salary = 60000 },
                new Employee { EmployeeID = 3, Name = "Kalpit", Salary = 50000 },
                new Employee { EmployeeID = 4, Name = "Shrishti", Salary = 340000 },
                new Employee { EmployeeID = 5, Name = "Lakshay", Salary = 70000 }
            };

        
            var highestPaidEmployee = employees.OrderByDescending(e => e.Salary).First();
            Console.WriteLine($"The employee with the highest salary is {highestPaidEmployee.Name} with a salary of {highestPaidEmployee.Salary}");

            
            Dictionary<int, string> employeeDictionary = new Dictionary<int, string>();
            foreach (var emp in employees)
            {
                employeeDictionary.Add(emp.EmployeeID, emp.Name);
            }

            
            Console.WriteLine("\nEmployee Dictionary:");
            foreach (var entry in employeeDictionary)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }

            
            int searchId = 3;
            if (employeeDictionary.ContainsKey(searchId))
            {
                Console.WriteLine($"\nEmployee with ID {searchId} is {employeeDictionary[searchId]}");
            }
            else
            {
                Console.WriteLine($"\nEmployee with ID {searchId} not found.");
            }

            Console.ReadLine();
        }
    }
}
