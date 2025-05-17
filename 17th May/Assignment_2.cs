/* 
Exercise 2: Interface - Customer Support System
💡 Problem Statement:
Create an interface to manage customer support tickets.
Instructions:
Create an interface ISupportTicket with methods:
CreateTicket(string issue)
ResolveTicket(int ticketId)
Implement the interface in two classes:
EmailSupport:
Prints "Creating ticket via Email: [issue]"
Prints "Resolving ticket [ticketId] via Email"
PhoneSupport:
Prints "Creating ticket via Phone: [issue]"
Prints "Resolving ticket [ticketId] via Phone"
In the Main() method:
Create objects of both classes using the ISupportTicket reference.
Call both methods for each object. 

*/

using System;
using System.Collections.Generic;

class SupportTicket
{
    public void CreateTicketViaEmail(string issue)
    {
        Console.WriteLine("Creating ticket via Email: " + issue);
    }

    public void ResolveTicketViaEmail(int ticketId)
    {
        Console.WriteLine("Resolving ticket " + ticketId + " via Email");
    }

    public void CreateTicketViaPhone(string issue)
    {
        Console.WriteLine("Creating ticket via Phone: " + issue);
    }

    public void ResolveTicketViaPhone(int ticketId)
    {
        Console.WriteLine("Resolving ticket " + ticketId + " via Phone");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SupportTicket support = new SupportTicket();

        // Creating tickets
        support.CreateTicketViaEmail("Issue with product");
        support.CreateTicketViaPhone("Issue with service");

        // Resolving tickets
        support.ResolveTicketViaEmail(123);
        support.ResolveTicketViaPhone(456);
    }
}