/* 
Exercise 3: Abstract Class Payment Gateway

Problem Statement:

Create an abstract class to handle payment processing.

Instructions:

1. Create an abstract class Payment Gateway with:

An abstract method: Process Payment(double amount)

A concrete method: Show GatewayName() to print "Processing payment through gateway"

2. Create derived classes

StripeGateway, Implements Process Payment() to print "Processing payment through Stripe: amount"

PayPalGateway: Implements ProcessPayment() to print "Processing payment through PayPal: Ramount

3. In the Main() method:

Create objects of both derived classes using the Payment Gateway reference.

Call ShowGatewayName() and Process Payment() for both objects. 

*/ 

using System; 
using System.Collections.Generic; 
using System.Linq; 

abstract class PaymentGateway
{ 
    public abstract void ProcessPayment(double amount); 

    public void ShowGatewayName 
    { 
        Console.WriteLine("Processing payment through gateway");  
    } 


} 

class StripeGateway : PaymentGateway 
{
    public override void ProcessPayment(double amount) 
    { 
        Console.WriteLine("Processing Payment through Stripe: " + amount); 
    } 
} 

class PayPalGateway : PaymentGateway 
{ 
       public override void ProcessPayment(double amount) 
    { 
        Console.WriteLine("Processing Payment through Paypal: " + amount); 
    } 
} 

class Program 
{ 
    static void Main(string[] args) 
    { 
        PaymentGateway stripeGateway = new StripeGateway(); 
        PaymentGateway paypalGateway = new PayPalGateway(); 

        stripeGateway.ShowGatewayName(); 
        stripeGateway.ProcessPayment(100); 

        paypalGateway.ShowGatewayName(); 
        paypalGateway.ProcessPayment(200); 
    } 
        
}        