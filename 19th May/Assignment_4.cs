/* 
Exercise 4: Abstract Class and Polymorphism - Payment Processing
💡 Problem Statement:
Create an abstract class to handle multiple payment methods with polymorphism.
Instructions:
Create an abstract class PaymentMethod with:
An abstract method: ProcessPayment(decimal amount)
A concrete method: ShowPaymentMethod() to print "Payment Method: [Method]"
Create derived classes:
CreditCardPayment:
Implements ProcessPayment() to print "Processing credit card payment of ₹amount"
UPIPayment:
Implements ProcessPayment() to print "Processing UPI payment of ₹amount"
In the Main() method:
Create objects of CreditCardPayment and UPIPayment using PaymentMethod reference.
Call ShowPaymentMethod() and ProcessPayment() for both objects.
Demonstrate polymorphism by calling the ProcessPayment() method using the base class reference. 
*/

using System;

namespace Assignment_4
{
    public abstract class PaymentMethod
    {
        public abstract void ProcessPayment(decimal amount);

        public void ShowPaymentMethod()
        {
            Console.WriteLine("Payment Method: [Method]");
        }


    }

    class CreditCardPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of ₹{amount}");
        }
    }
    class UPIPayment : PaymentMethod
    {

        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing UPIpayment of ₹{amount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod creditCard = new CreditCardPayment();
            creditCard.ShowPaymentMethod();
            creditCard.ProcessPayment(1000);

            PaymentMethod upi = new UPIPayment();
            upi.ShowPaymentMethod();
            upi.ProcessPayment(500);

            

        }
    }

}
