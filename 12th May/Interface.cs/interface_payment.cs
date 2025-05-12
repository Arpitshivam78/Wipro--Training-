interface IPayment 
{ 
    void ProcessPayment(); 
} 

class CreditCardPayment : Payment 
{ 
    public void ProcessPayment() 
    { 
        Console.WriteLine("Processing Credit Card Payment"); 
    } 


} 
class PayPalPayment :Payment 
{ 
    public void ProcessPayment(decimal Amount) 

    { 
     Console.WriteLine("Processing PayPal Payment"); 
    }
} 

class Program 
{ 
    static void Main() 
    {   
        IPayment payment;        

        Payment payment1 = new CreditCardPayment(); 
        payment1.ProcessPayment(1500.50m);  

        Payment payment2 = new PayPalPayment();
        payment2.ProcessPayment(2500.75m ); 
    }
}