//Create a pirogram that takes a muimber from 1 to 7 amd prints the conresponding day off the week.. 

using System;

public class Day
{
    public static void Main(string[] args)
    {
        int a = 7;

        if (a == 1)
        {
            Console.WriteLine("Monday");
        }
        else if (a == 2)
        {
            Console.WriteLine("Tuesday");
        }
        else if (a == 3)
        {
            Console.WriteLine("Wednesday");
        }
        else if (a == 4)
        {
            Console.WriteLine("Thursday");
        }
        else if (a == 5)
        {
            Console.WriteLine("Friday");
        }
        else if (a == 6)
        {
            Console.WriteLine("Saturday");
        }
        else if (a == 7)
        {
            Console.WriteLine("Sunday");
        }
        else
        {
            Console.WriteLine("Invalid number. Please enter a number from 1 to 7.");
        }
    }
}


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
