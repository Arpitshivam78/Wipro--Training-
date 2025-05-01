using System;

class Program
{
    static int FindMax(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Array is empty or null.");
            return int.MinValue; // Returns the smallest possible integer value
        }

        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    static void Main()
    {
        int[] scores = { 45, 67, 89, 23, 90 };
        Console.WriteLine("Max score: " + FindMax(scores)); 
    }
} 
