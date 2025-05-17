/* 
Exercise 4: Abstract Class - Animal Behavior
💡 Problem Statement:
Create an abstract class to represent different animal behaviors.
Instructions:
Create an abstract class Animal with:
An abstract method: MakeSound()
A concrete method: Eat() to print "Animal is eating"
Create derived classes:
Dog: Implements MakeSound() to print "Barks"
Cat: Implements MakeSound() to print "Meows"
In the Main() method:
Create objects of both classes using the Animal reference.
Call Eat() and MakeSound() for both objects. 

*/

using System; 
using System.Collections.Generic; 

using System.Linq; 

namespace Assignment_4
{ 
    public abstract class Animal 
    { 
        public abstract void MakeSound(); 
        public void Eat() 
        { 
            Console.WriteLine("Animal is eating"); 
        } 
    } 

    public class Dog : Animal 
    { 
        public override void MakeSound() 
        { 
            Console.WriteLine("Barks"); 
        } 
    } 

    public class Cat : Animal 
    { 
        public override void MakeSound() 
        { 
            Console.WriteLine("Meows"); 
        } 
    } 
} 

class Program 
{
    static void Main(string[] args)
    {
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.MakeSound(); 
        dog.Eat(); 

        cat.MakeSound(); 
        cat.Eat();

    } 
}          
