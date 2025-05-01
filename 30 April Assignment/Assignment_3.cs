// Exercise 3: Reverse a number (e.g., 123321).


using System;

class HelloWorld
{
    public static void Main(string[] args)
    {
        int i = 12345;       
        int reversed = 0;   

        while (i > 0)
        {
            int digit = i % 10;            
            reversed = reversed * 10 + digit; 
            i = i / 10;       
        }

        Console.WriteLine("Reversed number: " + reversed);
    }
}
