/* 
 1. Interface + Inheritance + Polymorphism – Payment Gateway System
 Task:
 Create an interface IPaymentProcessor with ProcessPayment().
 Create an abstract class PaymentGateway with GatewayName and a method
 Validate().
 Implement Razorpay, PayPal, and Stripe classes.
 Process multiple payments polymorphically from a list of IPaymentProcessor.
*/

using System;
using System.Collections.Generic;

namespace PaymentGatewaySystem
{
    // Interface defining the contract for payment processors
    public interface IPaymentProcessor
    {
        void ProcessPayment();
    }

    // Abstract class representing a generic payment gateway
    public abstract class PaymentGateway
    {
        public string GatewayName { get; set; }

        public virtual bool Validate()
        {
            // Implement validation logic here
            return true;
        }
    }

    // Razorpay implementation
    public class Razorpay : PaymentGateway, IPaymentProcessor
    {
        public Razorpay()
        {
            GatewayName = "Razorpay";
        }

        public void ProcessPayment()
        {
            if (Validate())
            {
                Console.WriteLine($"Processing payment through {GatewayName}");
            }
        }
    }

    // PayPal implementation
    public class PayPal : PaymentGateway, IPaymentProcessor
    {
        public PayPal()
        {
            GatewayName = "PayPal";
        }

        public void ProcessPayment()
        {
            if (Validate())
            {
                Console.WriteLine($"Processing payment through {GatewayName}");
            }
        }
    }

    // Stripe implementation
    public class Stripe : PaymentGateway, IPaymentProcessor
    {
        public Stripe()
        {
            GatewayName = "Stripe";
        }

        public void ProcessPayment()
        {
            if (Validate())
            {
                Console.WriteLine($"Processing payment through {GatewayName}");
            }
        }
    }

    // Class responsible for processing multiple payments
    public class PaymentGatewaySystem
    {
        public void ProcessMultiplePayments(List<IPaymentProcessor> processors)
        {
            foreach (IPaymentProcessor processor in processors)
            {
                processor.ProcessPayment();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            List<IPaymentProcessor> paymentProcessors = new List<IPaymentProcessor>
            {
                new Razorpay(),
                new PayPal(),
                new Stripe()
            };

            PaymentGatewaySystem gatewaySystem = new PaymentGatewaySystem();
            gatewaySystem.ProcessMultiplePayments(paymentProcessors);
        }
    }
}

