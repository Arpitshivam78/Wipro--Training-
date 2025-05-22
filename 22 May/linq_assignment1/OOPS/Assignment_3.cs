/* 
Exercise 3: Staff Management – Interface + Abstract Class
 Problem:
 Use both an interface and abstract class to model employees.
 Instructions:
 1. Create an interface IAttendance with method MarkAttendance()
 2. Create an abstract class Staff with:
 Properties: Id, Name, Department
 Abstract method: CalculateSalary()
 3. Create classes PermanentStaff and ContractStaff:
Implement both IAttendance and Staff
 Implement CalculateSalary() differently
 4. In Main(), use polymorphism to work with a list of staff
*/ 

using System;
using System.Collections.Generic;

public interface IAttendance
{
    void MarkAttendance();
}

public abstract class Staff
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public Staff(int id, string name, string department)
    {
        Id = id;
        Name = name;
        Department = department;
    }

    public abstract double CalculateSalary();
}

public class PermanentStaff : Staff, IAttendance
{
    public double BasicPay { get; set; }

    public PermanentStaff(int id, string name, string department, double basicPay)
        : base(id, name, department)
    {
        BasicPay = basicPay;
    }

    public override double CalculateSalary()
    {
        return BasicPay + (0.2 * BasicPay) + (0.1 * BasicPay);
    }

    public void MarkAttendance()
    {
        Console.WriteLine($"Permanent staff {Name} has marked attendance.");
    }
}

public class ContractStaff : Staff, IAttendance
{
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public ContractStaff(int id, string name, string department, double hourlyRate, int hoursWorked)
        : base(id, name, department)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }

    public void MarkAttendance()
    {
        Console.WriteLine($"Contract staff {Name} has marked attendance.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Staff> staffList = new List<Staff>
        {
            new PermanentStaff(1, "Alice", "HR", 50000),
            new ContractStaff(2, "Bob", "IT", 200, 160),
            new PermanentStaff(3, "Charlie", "Finance", 60000),
            new ContractStaff(4, "Diana", "Marketing", 180, 150)
        };

        foreach (var staff in staffList)
        {
            Console.WriteLine($"ID: {staff.Id}, Name: {staff.Name}, Department: {staff.Department}, Salary: {staff.CalculateSalary():C}");

            if (staff is IAttendance attendance)
            {
                attendance.MarkAttendance();
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

