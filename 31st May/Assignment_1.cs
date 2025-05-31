/* 
1. Vehicle Rental System (OOP + Inheritance + Interface)
 Concepts: Classes, Inheritance, Interfaces, Polymorphism Task:
 Base class: Vehicle
 Subclasses: Car, Bike, Truck
 Interface: IRentable with method Rent()
 Display rent cost per day and allow renting multiple vehicles
*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        IRentable car = new Car();
        IRentable Bike = new Bike();
        IRentable Truck = new Truck();

        car.Rent();
        Bike.Rent();
        Truck.Rent();
    }

    public interface IRentable
    {
        void Rent();


    }

    public class Car : IRentable
    {
        public void Rent()
        {
            Console.WriteLine("Car is being rented");
        } 
    } 
    public class Bike : IRentable
    {
        public void Rent()
        {
            Console.WriteLine("Bike is being rented");
        }
    }
    public class Truck : IRentable
    {
        public void Rent()
        {
            Console.WriteLine("Truck is being rented");
        }
    }
    
      
}  