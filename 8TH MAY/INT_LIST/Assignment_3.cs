// Exercise 2: Integer Operations

// Create an ArrayList of integers.

// Add 10 random numbers between 1 and 50.

// Sort the list in ascending order

// Find and print the maximum and minimum values.

// Calculate the average of all numbers.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 1, 50, 60, 70, 80, 90, 100, 110, 120 };

        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(1, 51));
        }

        numbers.Sort();
        Console.WriteLine("Sorted List:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        int max = numbers[0];
        int min = numbers[0];
        int sum = 0;

        foreach (int number in numbers)
        {
            if (number > max) max = number;
            if (number < min) min = number;
            sum += number;
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine("Maximum Value: " + max);
        Console.WriteLine("Minimum Value: " + min);
        Console.WriteLine("Average Value: " + average);
        Console.WriteLine("List Contains 10: " + numbers.Contains(10));
    }
}
