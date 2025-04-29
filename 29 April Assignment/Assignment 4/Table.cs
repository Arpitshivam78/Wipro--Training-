

using System;

class HelloWorld 
{
    static void table(int a) 
    {
        for (int i = 1; i <= 10; i++) 
        {
            Console.WriteLine(a + " * " + i + " = " + (a * i));
        }
    }

    public static void Main()
    {
        table(5);
    }
}
