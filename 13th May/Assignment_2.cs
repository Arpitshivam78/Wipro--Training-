/* 
Exercise 2: Interface - Restaurant Order Management

Problem Statement:

Create an interface to handle order processing in a restaurant.

Instructions:

1. Create an interface IOrder with methods:

PlaceOrder(string item)

CancelOrder(string item)

2. Implement the interface in two classes:

DinelnOrder: Print "Placing dine-in order for item" and "Canceling dine-in order for item

TakeawayOrder Print "Placing takeaway order for item" and "Canceling takeaway order for item

3. In the Main() method:

Create objects of DinelnOrder and TakeawayOrder using Order reference.

Call both methods for each object

*/  

using System; 
using System.Collections.Generic; 
using System.Linq;

class Order 
{ 
    public void PlaceOrder(string item) 
    {
        Console.WriteLine("Placing order for item: " + item);  
    } 

    public void CancelOrder(string item) 
    { 
        Console.WriteLine("Cancelling oder for item : " + item); 
    } 
} 

class DinelnOrder : Order 
{ 
    public void PlaceOrder(string item) 
    { 
        Console.WriteLine("Place dine_in Order for item" + item); 
    } 

    public void CancelOrder(string item) 
    { 
        Console.WriteLine("Cancel dine_in Order for item" + item); 
    }
} 

class TakeawayOrder : Order 
{ 
    public void PlaceOrder(string item) 
    { 
        Console.WriteLine("Place takeaway Order for item" + item); 
    } 

    public void CancelOrder(string item) 
    { 
        Console.WriteLine("Cancel takeaway Order for item" + item); 
    }  

} 

class Program 
{ 
    static void Main(string[] args){ 
        Order order = new Order(); 
        order.PlaceOrder("Pizza"); 
        order.PlaceOrder("pizza without cheese");  
        order.CancelOrder("who orders pizza without cheese");  

        DinelnOrder dineInOrder = new DinelnOrder(); 
        dineInOrder.PlaceOrder("Pizza"); 
        dineInOrder.PlaceOrder("pizza without cheese"); 
        dineInOrder.CancelOrder("who orders pizza without cheese");   

        TakeawayOrder takeawayOrder = new TakeawayOrder(); 
        takeawayOrder.PlaceOrder("Pizza"); 
        takeawayOrder.PlaceOrder("pizza without cheese"); 
        takeawayOrder.CancelOrder("who orders pizza without cheese");
         
        Console.WriteLine("Order processing completed."); 

    }
}