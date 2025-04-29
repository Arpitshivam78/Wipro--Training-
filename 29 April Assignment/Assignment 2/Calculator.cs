using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        int age  = 25;
        double Fees = 2345.67;
        string name = "jj"; 
        bool istudent = true; 
        Console.WriteLine ("hellow world"); 
        Console.WriteLine ("age" + age); 
        Console.WriteLine ("Fees" + Fees); 
        Console.WriteLine ("name" + name); 
        Console.WriteLine ("isStudent" + istudent);
    } 
} 

// Add 
using System;

public class HelloWorld
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    public static void Main()
    {
        int num1 = 45;
        int num2 = 67;

        Console.WriteLine("Addition: " + Add(num1, num2));
    }
} 



