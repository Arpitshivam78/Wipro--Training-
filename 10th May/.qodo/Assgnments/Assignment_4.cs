// Problem Statement:

// Paragraph

// Create a smart home system using inheritance to manage different types of devices.

//Instructions:

//1. Create a base class SmartDevice with fields:

//DeviceName (string)

//PowerStatus (bool)

//Method: TogglePower() to switch the power status

//2. Create two derived classes:

// SmartLight with an additional field: Brightness (int)

//Smart Thermostat with an additional field: Temperature (double)

//3. Add methods to change brightness and temperature respectively.

//4. In the Main() method:

//Create objects of SmartLight and Smart Thermostat

//Switch the power on/off and adjust brightness/temperature

//Print the device status 

//using System; 
//using System.Collections.Generic; 

using System;

class SmartDevice
{
    public string DeviceName { get; set; }
    public bool PowerStatus { get; set; }

    public SmartDevice(string DeviceName)
    {
        this.DeviceName = DeviceName;
        PowerStatus = false;
    }

    public void TogglePower()
    {
        PowerStatus = !PowerStatus;
        Console.WriteLine($"{DeviceName} power status: {(PowerStatus ? "On" : "Off")}");
    }

    public virtual void PrintStatus()
    {
        Console.WriteLine($"Device Name: {DeviceName}, Power Status: {(PowerStatus ? "On" : "Off")}");
    }
}

class SmartLight : SmartDevice
{
    public int Brightness { get; set; }

    public SmartLight(string DeviceName, int Brightness) : base(DeviceName)
    {
        this.Brightness = Brightness;
    }

    public void ChangeBrightness(int newBrightness)
    {
        Brightness = newBrightness;
        Console.WriteLine($"{DeviceName} brightness set to: {Brightness}");
    }

    public override void PrintStatus()
    {
        base.PrintStatus();
        Console.WriteLine($"Brightness: {Brightness}");
    }
}

class Program
{
    static void Main()
    {
        SmartLight myLight = new SmartLight("Bedroom Light", 75);
        myLight.PrintStatus();
        myLight.TogglePower();
        myLight.ChangeBrightness(90);
        myLight.PrintStatus();
    }
}
