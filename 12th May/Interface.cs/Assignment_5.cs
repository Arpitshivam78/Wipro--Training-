/* 
   Exercise 4: Abstract Class - Notification System

Problem Statement:

Create an abstract class to handle different types of notifications.

Instructions:

1. Create an abstract class Notification with:

An abstract method:

Send()

A concrete method: Show Type() to print "Sending Notification"

2. Create derived classes:

Email Notification: Implements Send() to print "Sending Email Notification"

SMSNotification: Implements Send() to print "Sending SMS Notification"

3. In the Main() method:

Create objects of both derived classes using the Notification reference.

Call ShowType() and Send() for both objects.
*/  


using System; 

abstract class Notification 
{ 
    public abstract void Send(); 
    public void ShowType() 
    { 
        Console.WriteLine("Sending Notification"); 
    } 
} 

class EmailNotification : Notification 
{ 
    public override void Send() 
    { 
        Console.WriteLine("Sending Email Notification"); 
    } 
} 

class SMSNotification : Notification    

{ 
    public override void Send() 
    { 
        Console.WriteLine("Sending SMS Notification"); 
    } 
} 

class Program 
{ 
    static void Main() 
    { 
        Notification email = new EmailNotification(); 
        email.ShowType(); 
        email.Send(); 
        
        Notification sms = new SMSNotification(); 
        sms.ShowType(); 
        sms.Send(); 
    } 
}