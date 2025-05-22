/* 
 Exercise 2: Dictionary – Employee Salary Lookup
 Problem:
Build a salary lookup table using 
Dictionary<int, decimal> .
 Instructions:
 1. Use Employee ID as the key, Salary as the value.
 2. Add 4–5 employees.
 3. Ask the user to enter an Employee ID.
 4. Display their salary if found
*/
using System;
using System.Collections.Generic; 

namespace Assignment_2
{ 
    class Employee
    { 
        public int Id { get; set; } 
        public string Name { get; set; } 
        public decimal Salary { get; set; } 
    } 

    class Program
    { 
        static void Main(string[] args)
        { 
            Dictionary<int, decimal> employeeSalaries = new Dictionary<int, decimal>(); 
            employeeSalaries.Add(1, 50000); 
            employeeSalaries.Add(2, 60000); 
            employeeSalaries.Add(3, 70000); 
            employeeSalaries.Add(4, 80000); 
            employeeSalaries.Add(5, 90000); 

            Console.WriteLine("Enter Employee ID: "); 

            int employeeId = Convert.ToInt32(Console.ReadLine());

            if (employeeSalaries.ContainsKey(employeeId))
            { 
                decimal salary = employeeSalaries[employeeId]; 
                Console.WriteLine($"Employee ID: {employeeId}, Salary: {salary}");  
            } 
            else
            { 
                Console.WriteLine("Employee not found."); 
            } 
        } 
    } 
}