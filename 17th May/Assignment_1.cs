/* 
Exercise 1: Interface - Vehicle Maintenance
💡 Problem Statement:
Create an interface to manage vehicle maintenance tasks.
Instructions:
Create an interface IMaintenance with methods:
Service()
Repair()
Implement the interface in two classes:
CarMaintenance:
Service(): Print "Car is being serviced"
Repair(): Print "Car is being repaired"
BikeMaintenance:
Service(): Print "Bike is being serviced"
Repair(): Print "Bike is being repaired"
In the Main() method:
Create objects of CarMaintenance and BikeMaintenance using the IMaintenance reference.
Call both methods for each object. 
*/

using System; 
using System.Collections.Generic;

class Maintenance
{
    public interface IMaintenance
    {
        void Service(); 
        void Repair(); 
    } 
}

class CarMaintenance : Maintenance.IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Car is Being Used");
    } 
    
    public void Repair()
    {
        Console.WriteLine(" Car is being reapaired");
    } 
}

class BikeMaintenance : Maintenance.IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Bike is Being Used");
    }

    public void Repair()
    {
        Console.WriteLine("Bike is being Used");
    }
}  

class Program
{
    static void Main(string[] args)
    {
        Maintenance.IMaintenance car = new CarMaintenance();
        Maintenance.IMaintenance bike = new BikeMaintenance();

        car.Service();
        car.Repair();

        bike.Service();
        bike.Repair();
    }
} 

