/* 
Exercise 3: Abstract Class - Ticket Booking System
💡 Problem Statement:
Create an abstract class to handle ticket booking for different modes of transport.
Instructions:
Create an abstract class TicketBooking with:
An abstract method: BookTicket(int seats)
A concrete method: ShowBookingInfo() to print "Booking tickets"
Create derived classes:
BusBooking: Implements BookTicket() to print "Booking x bus tickets"
FlightBooking: Implements BookTicket() to print "Booking x flight tickets"
In the Main() method:
Create objects of BusBooking and FlightBooking using the TicketBooking reference.
Call ShowBookingInfo() and BookTicket() for both objects.

*/  

using System; 

using System.Collections.Generic; 

using System.Linq; 


abstract class TicketBooking 
{ 
    public abstract void BookTicket(int seats); 
    public void ShowBookingInfo() 
    { 
        Console.WriteLine("Booking tickets..."); 
    }  


} 

class BusBooking : TicketBooking 
{ 
    public override void BookTicket(int seats) 
    { 
        Console.WriteLine("Booking " + seats + " bus tickets"); 
    }  
} 

class FlightBooking : TicketBooking 
{ 
    public override void BookTicket(int seats) 
    { 
        Console.WriteLine("Booking " + seats + " flight tickets"); 
    }  
} 

class Program 
{ 
    static void Main(string[] args) 
    { 
        TicketBooking busBooking = new BusBooking(); 
        busBooking.ShowBookingInfo(); 
        busBooking.BookTicket(5); 

        TicketBooking flightBooking = new FlightBooking(); 
        flightBooking.ShowBookingInfo(); 
        flightBooking.BookTicket(3); 
    }  
} 

/* 
using System.Diagnostics;
using A_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace A_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
/*
