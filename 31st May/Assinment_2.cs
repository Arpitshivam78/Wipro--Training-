/* 
  2. Employee Directory with LINQ
 Concepts: Collections, LINQ, Filtering, Sorting Task:
 Create a list of Employee objects with ID, Name, Department, Salary
 Filter employees by department
 Sort by salary descending
 Find average salary per department.
*/  

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        list<employee> employee = new list<employee>();

        employee.add(new employee { id = 1, name = "Arpit", department = "IT", salary = 50000 });
        employee.add(new employee { id = 2, name = "Akriti", department = "HR", salary = 60000 });
        employee.add(new employee { id = 3, name = "Kalpit", department = "IT", salary = 70000 });
        employee.add(new employee { id = 4, name = "Shrishti", department = "HR", salary = 80000 });
        employee.add(new employee { id = 5, name = "Lakshay", department = "IT", salary = 90000 });

        var filteredEmployees = employee.where(e => e.department == "IT").tolist();
        var sortedEmployees = employee.orderbyDescending(e => e.salary).tolist();
        var averageSalary = employee.groupby(e => e.department).select(g => new { Department = g.key, AverageSalary = g.average(e => e.salary) }).tolist();
    } 
    
    
}