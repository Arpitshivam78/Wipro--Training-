// Tank Power Calculation

// Add methods to calculate power (x*y):

// Two integers (int base, int exponent)

// Two doubles (double base, double exponent)

// Print the result of and 2 ^ 3 and 5.5 ^ 2. 

// Add a method to calculate the power of a number (int base, int exponent) using recursion. 


using System;

class PowerCalculator
{
    // Method for integers
    public static int CalculatePower(int baseVal, int exponent)
    {
        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseVal;
        }
        return result;
    }

    // Method for doubles
    public static double CalculatePower(double baseVal, double exponent)
    {
        return Math.Pow(baseVal, exponent);
    }
}

class Program
{
    static void Main()
    {
        int intResult = PowerCalculator.CalculatePower(2, 3); 
        double doubleResult = PowerCalculator.CalculatePower(5.5, 2); 

        Console.WriteLine("2 ^ 3 = " + intResult);
        Console.WriteLine("5.5 ^ 2 = " + doubleResult);
    }
}
