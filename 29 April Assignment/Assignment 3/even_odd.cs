using System;

public class HelloWorld
{
    static void Even_odd(int a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine("It is an even number");
        }
        else
        {
            Console.WriteLine("It is an odd number");
        }
    }

    public static void Main()
    {
        int num1 = 45;
        int num2 = 67;

        Even_odd(num1);
        Even_odd(num2);
    }
}

