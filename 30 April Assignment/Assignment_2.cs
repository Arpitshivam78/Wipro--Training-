//Exercise 2: Find the sum of digits of a number using for loop, switch case and while loop. 

using System;

public class HelloWorld
{
    static int Sum(int a, int b)
    {  
        int sum = 0; 

        for (int i = 0; i < a; i++)
        { 
            sum++;
        } 
        
        for (int i = 0; i < b; i++)
        { 
            sum++;
        }  

        return sum; 
    }  
    
    static void Main(string[] args)
    { 
        int result = Sum(65, 67);
        Console.WriteLine("The sum is: " + result); 
    }
}
