// Count number of zeros in a number (recursively) - 2004350510 

using System;

class Program
{
    static int countzeros(int n)
    {
        if (n == 0)
            return 0;

        int lastDigit = n % 10;

        if (lastDigit == 0)
            return 1 + countzeros(n / 10);
        else
            return countzeros(n / 10);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(countzeros(2004350510)); // Output: 4
    }
}
