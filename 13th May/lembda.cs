using System;
using System.Linq;

namespace LingPractice
{
    class Program12
    {
        class Employee
        {
            public int EmployeeID { get; set; }
            public string EmployeeName { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            Employee[] employeeArray = {
                new Employee() { EmployeeID = 1, EmployeeName = "John", Age = 18 },
                new Employee() { EmployeeID = 2, EmployeeName = "Steve", Age = 21 },
                new Employee() { EmployeeID = 3, EmployeeName = "Bill", Age = 25 },
                new Employee() { EmployeeID = 4, EmployeeName = "Ram", Age = 20 },
                new Employee() { EmployeeID = 5, EmployeeName = "Ron", Age = 31 },
                new Employee() { EmployeeID = 6, EmployeeName = "Chris", Age = 17 },
                new Employee() { EmployeeID = 7, EmployeeName = "Jessica", Age = 22 }
            };

            // Use LINQ to find teenager Employees (Age between 13 and 19)
            Employee[] teenAgerEmployees = employeeArray
                .Where(s => s.Age > 12 && s.Age < 20)
                .ToArray();

            // Use LINQ to find first Employee whose name is Bill
            Employee bill = employeeArray
                .Where(s => s.EmployeeName == "Bill")
                .FirstOrDefault();

            // Use LINQ to find Employee whose EmployeeID is 5
            Employee employee5 = employeeArray
                .Where(s => s.EmployeeID == 5)
                .FirstOrDefault();

            // Display results
            Console.WriteLine("Teenager Employees:");
            foreach (var emp in teenAgerEmployees)
            {
                Console.WriteLine($"ID: {emp.EmployeeID}, Name: {emp.EmployeeName}, Age: {emp.Age}");
            }

            Console.WriteLine("\nEmployee named Bill:");
            if (bill != null)
                Console.WriteLine($"ID: {bill.EmployeeID}, Name: {bill.EmployeeName}, Age: {bill.Age}");

            Console.WriteLine("\nEmployee with ID 5:");
            if (employee5 != null)
                Console.WriteLine($"ID: {employee5.EmployeeID}, Name: {employee5.EmployeeName}, Age: {employee5.Age}");
        }
    }
}