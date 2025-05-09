using System;
class Animal
{
    public string Name;
    public string Species;

    public void DisplayAnimal()
    {
        Console.WriteLine($"Name: {Name}, Species: {Species}");
    }
}

class Dog : Animal
{
    public string Breed;

    public void DisplayDog()
    {
        Console.WriteLine($"Breed: {Breed}");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Name = "Buddy";
        myDog.Breed = "Siberian Mastiff";
        myDog.Species = "Canine";

        myDog.DisplayAnimal(); // from Animal class
        myDog.DisplayDog();    // from Dog class
    }
}


