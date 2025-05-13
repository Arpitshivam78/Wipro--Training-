Exercise 1: Interface - Transportation System

Problem Statement:

Create an interface to manage different modes of transportation.

Instructions:

1. Create an interface ITransport with methods:

Start(): Print "Starting the transport"

Stop(): Print "Stopping the transport"

2. Implement the interface in two classes:

Bus: Print "Bus is starting" and "Bus is stopping"

Train: Print "Train is starting" and "Train is stopping"

3. In the Main() method:

Create objects of both classes using the ITransport reference.

Call both methods for each object. 

*/

using System;

using System.Collections.Generic;

using System.Linq;

class ITransport
{
    public void Start()
    {
        Console.WriteLine("Starting the Transport");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping the Transport");
    }

    public void Display()
    {
        Console.WriteLine("This is a Transport");
    }


}

class Bus : ITransport
{
    public void Start()
    {
        Console.WriteLine("Bus is starting");
    }
    public void Stop()
    {
        Console.WriteLine("Bus is stopping");
    }


}

class Train : ITransport
{
    public void Start()
    {
        Console.WriteLine("Train is Starting");

    }
    public void Strop()
    {
        Console.WriteLine("Train is Stopping");
    }


}

class Program
{

    static void Main(string[] args)
    {
        ITransport bus = new Bus();
        bus.Start();
        bus.Stop();

        ITransport train = new Train();
        train.Start();
        train.Stop();
    }
}