/* 
Exercise 4: Abstract Class - Employee Hierarchy

Problem Statement: 

Create an abstract class to manage different types of employees.

Instructions:

1. Create an abstract class Employee with:

An abstract method: CalculateSalary()

Paragraph

A concrete method: ShowBasicInfo() to print "Employee details"

2. Create derived classes:

Help

AaBbCct

AaBbCct

AaB

Normal

No Spac

Husding

FullTimeEmployee: Implements CalculateSalary() to print "Salary: Basic + Allowance

PartTimeEmployee: Implements CalculateSalary() to print "Salary: Hourly rate x Hours worked I

3. In the Main() method:

Create objects of FullTime Employee and PartTimeEmployee using the Employee reference.

Call ShowBasicInfo() and CalculateSalary() for both objects 

*/ 

using System; 
using System.Collections.Generic; 
using System.Linq;  

abstract class Employee 
{ 
    public abstract void CalculateSalary(); 
    public void ShowBasicInfo() 
    { 
        Console.WriteLine("Employee details"); 
    }  
} 

class FullTimeEmployee : Employee 
{ 
    public override void CalculateSalary() 
    { 
        Console.WriteLine("Salary: Basic + Allowance"); 
    } 
} 

class PartTimeEmployee : Employee 
{ 
    public override void CalculateSalary() 
    { 
        Console.WriteLine("Salary: Hourly rate x Hours worked"); 
    } 
}

class Program 
{ 
    static void Main(string[] args) 
    { 
        Employee fullTimeEmployee = new FullTimeEmployee(); 
        Employee partTimeEmployee = new PartTimeEmployee(); 

        fullTimeEmployee.ShowBasicInfo(); 
        fullTimeEmployee.CalculateSalary(); 

        partTimeEmployee.ShowBasicInfo(); 
        partTimeEmployee.CalculateSalary(); 
    } 
} 

