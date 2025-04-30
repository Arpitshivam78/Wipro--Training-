using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int marks = 100;

        if (marks >= 90)
        {
            Console.WriteLine("A");
        }
        else if (marks >= 80)
        {
            Console.WriteLine("B");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("C");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("D");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("E");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}
