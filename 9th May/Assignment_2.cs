//Task 1: Vehicle and Car

//1. Create a base class Vehicle with fields:

//Make (string)

//Model (string)

//2. Add a method Display Vehicle() to print vehicle details.

//3. Create a derived class Car with an additional field:

//FuelType (string)

//4. Add a method DisplayCar() to print car-specific details.

//5. In the Main() method:

//Create a Car object and set values.

//Call both methods to print the complete details. 

using System;

namespace VehicleApp
{
    class Vehicle
    {
        public string Make;
        public string Model;

        public void DisplayVehicle()
        {
            Console.WriteLine($"Make : {Make}");
            Console.WriteLine($"Model : {Model}");
        }
    }

    class Car : Vehicle
    {
        public string FuelType;

        public void DisplayCar()
        {
            Console.WriteLine($"Fuel Type : {FuelType}");
        }
    }

    class Program
    {
        static void Main()
        {
            Car myCar = new Car();
            myCar.Make = "TATAMOTORS";
            myCar.Model = "TATA Harrier";
            myCar.FuelType = "Diesel";

            myCar.DisplayVehicle();
            myCar.DisplayCar();

            Console.WriteLine("Car Details:");
            Console.WriteLine($"Make : {myCar.Make}");
            Console.WriteLine($"Model : {myCar.Model}");
            Console.WriteLine($"Fuel Type : {myCar.FuelType}");
        }
    }
}
