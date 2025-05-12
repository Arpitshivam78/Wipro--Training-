/*
 Exercise 1: Interface - Device Control

 Problem Statement:

 Create an interface to manage electronic devices.

 Instructions:

 1. Create an interface IDeviceControl with methods:

    TurnOn()

    TurnOff()

 2. Implement the interface in two classes:

    SmartTV: Prints "SmartTV is now ON" and "SmartTV is now OFF"

    Speaker: Prints "Speaker is now ON" and "Speaker is now OFF"

 3. In the Main() method:

    Create objects of both classes using the IDevice Control reference.

    Turn both devices on and off.
*/ 

using System; 

interface DeviceControl 
{ 
    void TurnOn(); 
    void TurnOff(); 
} 

class SmartTV : DeviceControl 
{ 
    public void TurnOn() 
    { 
        Console.WriteLine("SmaertTV is now ON"); 
    } 

    public void TurnOff() 
    { 
        Console.WriteLine("SmartTV is now OFF"); 
    }  


} 

class Speaker : DeviceControl 
{ 
    public void TurnOn() 
    { 
        Console.WriteLine("Speaker is now ON");  
    } 

    public void TurnOff() 
    { 
        Console.WriteLine("Speaker is now OFF"); 
    } 


} 

class Program
{
    static void Main()
    {
        DeviceControl device; 

        device = new SmartTV();         
        device.TurnOn();
        device.TurnOff();

        device = new Speaker(); 
        device.TurnOn();
        device.TurnOff(); 

        Console.ReadLine();
    }
}