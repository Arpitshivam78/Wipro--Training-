/* 
Exercise 4: Abstract Class - Food Ordering System
💡 Problem Statement:
Create an abstract class to manage food ordering from different restaurants.
Instructions:
Create an abstract class FoodOrder with:
An abstract method: PlaceOrder(string item)
A concrete method: OrderInfo() to print "Placing food order"
Create derived classes:
FastFoodOrder: Implements PlaceOrder() to print "Order placed for [item] at Fast Food Outlet"
FineDiningOrder: Implements PlaceOrder() to print "Order placed for [item] at Fine Dining Restaurant"
In the Main() method:
Create objects of FastFoodOrder and FineDiningOrder using the FoodOrder reference.
Call OrderInfo() and PlaceOrder() for both objects.

*/  


abstract class FoodOrder 
{ 
    public abstract void PlaceOrder(string item); 
    public void OrderInfo() 
    { 
        Console.WriteLine("Placing food order..."); 
    }  
}

class FastFoodOrder : FoodOrder 
{ 
    public override void PlaceOrder(string item) 
    { 
        Console.WriteLine("Order placed for " + item + " at Fast Food Outlet"); 
    }  
} 

class FineDiningOrder : FoodOrder 
{ 
    public override void PlaceOrder(string item) 
    { 
        Console.WriteLine("Order placed for " + item + " at Fine Dining Restaurant"); 
    }  
} 

class Program 
{ 
    static void Main(string[] args) 
    { 
        FoodOrder fastFoodOrder = new FastFoodOrder(); 
        fastFoodOrder.OrderInfo(); 
        fastFoodOrder.PlaceOrder("Burger"); 
    } 
}    

