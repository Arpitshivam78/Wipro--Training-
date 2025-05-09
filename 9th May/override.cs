using System;

class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("Manager is managing");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Work(); // Output: Employee is working

        Manager mgr = new Manager();
        mgr.Work(); // Output: Manager is managing

        Employee empMgr = new Manager();
        empMgr.Work(); // Output: Manager is managing (polymorphism)
    }
}
