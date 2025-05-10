using System;

class Payment
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }

    public virtual void ProcessPayment(decimal amount)
    {
        Amount = amount;
        Currency = "INR"; 
        Console.WriteLine($"Processing payment of {Amount} in {Currency}");
    }

    public virtual void ProcessPayment(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
        Console.WriteLine($"Processing payment of {Amount} in {Currency}");
    }
}

class CreditCardPayment : Payment
{
    public string CardNumber { get; set; }

    public override void ProcessPayment(decimal amount)
    {
        base.ProcessPayment(amount);
        Console.WriteLine($"Processing credit card payment with card number: {CardNumber}");
    }

    public override void ProcessPayment(decimal amount, string currency)
    {
        base.ProcessPayment(amount, currency);
        Console.WriteLine($"Processing credit card payment with card number: {CardNumber}");
    }

    public CreditCardPayment()
    {
        CardNumber = "1234-5678-9012-3456";
    }
}

class PayPalPayment : Payment
{
    public string EmailAddress { get; set; }

    public override void ProcessPayment(decimal amount)
    {
        base.ProcessPayment(amount);
        Console.WriteLine($"Processing PayPal payment with email address: {EmailAddress}");
    }

    public override void ProcessPayment(decimal amount, string currency)
    {
        base.ProcessPayment(amount, currency);
        Console.WriteLine($"Processing PayPal payment with email address: {EmailAddress}");
    }

    public PayPalPayment()
    {
        EmailAddress = "user@example.com";
    }
}

class OnlinePaymentSystem
{
    static void Main()
    {
        CreditCardPayment creditCardPayment = new CreditCardPayment();
        creditCardPayment.ProcessPayment(100.0m);
        creditCardPayment.ProcessPayment(200.0m, "USD");

        PayPalPayment payPalPayment = new PayPalPayment();
        payPalPayment.ProcessPayment(50.0m);
        payPalPayment.ProcessPayment(100.0m, "EUR");
    }
}
