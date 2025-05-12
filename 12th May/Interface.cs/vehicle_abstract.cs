using System; 

abstract class Vehicle 
{ 
    public string Brand; 
    public int Year; 

    public void DisplayInfo() 
    { 
        Console.WriteLine($"Brand : {Brand}, Year : {Year}"); 
    }  
    public abstract void Start(); 
}  

class Car: Vehicle 
{ 
    public void override Start() 
    { 
        Console.WriteLine("Car is starting");  
    } 
} 

class Bike : Vehicle 
{
    public override void Start()
    {
        Console.WriteLine9("Bike is starting"); 
    } 

    
}

 