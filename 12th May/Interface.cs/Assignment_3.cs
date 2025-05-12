/* 
Exercise 2: Interface Animal Actions

Problem Statement:

Create an interface to define basic animal actions.

Instructions:

1. Create an interface IAnimalActions with methods:

Eat()

Sleep()

2. Implement the interface in two classes:

Lion: Prints "Lion is eating meat" and "Lion is sleeping"

Elephant: Prints "Elephant is eating grass" and "Elephant is sleeping"

3. In the Main() method:

Create objects of Lion and Elephant using IAnimalActions reference.

Call both methods for each object.
*/  

using System; 

interface IAnimalActions 
{ 
    void Eat(); 
    void Sleep();
} 

class Lion : IAnimalActions 
{ 
    public void Eat() 
    { 
        Console.WriteLine("Lion is Eating meat");
    } 

   public void Sleep() 
    { 
        Console.WriteLine("Lion is sleeping");
    } 
     
} 

class Elephant : IAnimalActions 
{ 
    public void Eat() 
    { 
        Console.WriteLine("Elephant is eating grass"); 
    } 

    public void Sleep() 
    { 
        Console.WriteLine("Elephant is sleeping");
    }  

} 

class Program 
{ 
    static void Main() 
    { 
        IAnimalActions lion = new Lion(); 
        lion.Eat(); 
        lion.Sleep(); 

        IAnimalActions elephant = new Elephant(); 
        elephant.Eat(); 
        elephant.Sleep(); 
    } 
}