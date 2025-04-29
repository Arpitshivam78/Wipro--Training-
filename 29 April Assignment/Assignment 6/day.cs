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
