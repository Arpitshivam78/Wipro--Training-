/* 
Exercise 1: Interface and Abstract Class - Smart Home Devices
💡 Problem Statement:
Create a system to manage smart home devices using interfaces and abstract classes.
Instructions:
Create an abstract class SmartDevice with:
An abstract method: TurnOn()
A concrete method: ShowStatus() to print "Device status: Active"
Create an interface IRemoteControl with methods:
IncreaseVolume()
DecreaseVolume()
Create derived classes:
SmartLight:
Implements TurnOn() to print "Smart Light turned on"
Implements IncreaseVolume() and DecreaseVolume() to print "Lights do not support volume control"
SmartSpeaker:
Implements TurnOn() to print "Smart Speaker turned on"
Implements IncreaseVolume() and DecreaseVolume() to print "Volume increased/decreased"
In the Main() method:
Create objects of SmartLight and SmartSpeaker using SmartDevice reference.
Call ShowStatus(), TurnOn(), IncreaseVolume(), and DecreaseVolume() for both. 
*/ 

using System;

namespace Assignment_1
{
    
    abstract class SmartDevice
    {
        public abstract void TurnOn();

        public void ShowStatus()
        {
            Console.WriteLine("Device status: Active");
        }
    }

    
    interface IRemoteControl
    {
        void IncreaseVolume();
        void DecreaseVolume();
    }

    
    class SmartLight : SmartDevice, IRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("Smart Light turned on");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Lights do not support volume control");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("Lights do not support volume control");
        }
    }

    
    class SmartSpeaker : SmartDevice, IRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("Smart Speaker turned on");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Volume increased");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("Volume decreased");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            SmartDevice smartLight = new SmartLight();
            SmartDevice smartSpeaker = new SmartSpeaker();

            
            IRemoteControl lightControl = (IRemoteControl)smartLight;
            IRemoteControl speakerControl = (IRemoteControl)smartSpeaker;

            smartLight.ShowStatus();
            smartLight.TurnOn();
            lightControl.IncreaseVolume();
            lightControl.DecreaseVolume();

            Console.WriteLine();

            smartSpeaker.ShowStatus();
            smartSpeaker.TurnOn();
            speakerControl.IncreaseVolume();
            speakerControl.DecreaseVolume();
        }
    }
}
