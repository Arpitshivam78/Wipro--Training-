/* 
7. Calculator App (Method Overloading)
 Concepts: Overloading, Static methods Task:
 Overload 
Add() , 
Subtract() , 
Multiply()
 Different datatypes (int, float, double)
 Take user input and dynamically call correct method
*/

using System;

using System.Collections.Generic;

using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the fourth number: ");
        int num4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the fifth number: ");
        int num5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the sixth number: ");
        int num6 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the seventh number: ");
        int num7 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the eighth number: ");
        int num8 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the ninth number: ");
        int num9 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the tenth number: ");
        int num10 = Convert.ToInt32(Console.ReadLine());

        Calculator.Add(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10);
        Calculator.Subtract(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10);
        Calculator.Multiply(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10); 

        
    } 
    
}