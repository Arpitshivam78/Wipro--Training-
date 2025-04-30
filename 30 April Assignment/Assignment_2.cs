//Exercise 2: Find the sum of digits of a number using for loop, switch case and while loop. 

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num = 1234;
        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sum = sum + digit;
            num = num / 10;
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}
