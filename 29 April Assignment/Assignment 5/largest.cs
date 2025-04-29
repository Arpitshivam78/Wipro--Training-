using System;

class HelloWorld
{
    public static void Main(string[] args) 
    {
        int a = 10; 
        int b = 20; 
        int c = 30; 

        if (a > b && a > c) 
        {
            Console.WriteLine("a is the largest number"); 
        } 
        else if (b > a && b > c) 
        { 
            Console.WriteLine("b is the largest number"); 
        }    
        else 
        { 
            Console.WriteLine("c is the largest number"); 
        }
    }
}
