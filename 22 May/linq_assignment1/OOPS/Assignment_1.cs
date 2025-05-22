using System;
using System.Collections.Generic;

namespace Assignment_1
{
    // Abstract base class
    abstract class Vehicle
    {
        public string VehicleNumber { get; set; }
        public string Brand { get; set; }
        public double RatePerDay { get; set; }

        public Vehicle(string vehicleNumber, string brand, double ratePerDay)
        {
            VehicleNumber = vehicleNumber;
            Brand = brand;
            RatePerDay = ratePerDay;
        }

        public abstract double CalculateRent(int days);
    }

    // Derived class: Car
    class Car : Vehicle
    {
        public Car(string vehicleNumber, string brand, double ratePerDay)
            : base(vehicleNumber, brand, ratePerDay) { }

        public override double CalculateRent(int days)
        {
            double surcharge = 50; // Example surcharge
            return (RatePerDay * days) + surcharge;
        }
    }

    // Derived class: Bike
    class Bike : Vehicle
    {
        public Bike(string vehicleNumber, string brand, double ratePerDay)
            : base(vehicleNumber, brand, ratePerDay) { }

        public override double CalculateRent(int days)
        {
            double discount = 10; // Example discount
            return (RatePerDay * days) - discount;
        }
    }

    // Derived class: Truck
    class Truck : Vehicle
    {
        public Truck(string vehicleNumber, string brand, double ratePerDay)
            : base(vehicleNumber, brand, ratePerDay) { }

        public override double CalculateRent(int days)
        {
            double loadCharge = 100; // Example additional charge
            return (RatePerDay * days) + loadCharge;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("ABC123", "Toyota", 100),
                new Bike("DEF456", "Honda", 50),
                new Truck("GHI789", "Ford", 200)
            };

            int rentalDays = 5;

            foreach (var vehicle in vehicles)
            {
                double rent = vehicle.CalculateRent(rentalDays);
                Console.WriteLine($"Vehicle: {vehicle.Brand} ({vehicle.VehicleNumber})");
                Console.WriteLine($"Total Rent for {rentalDays} days: {rent:C}");
                Console.WriteLine();
            }

            Console.ReadLine();
        } 
    }
}
