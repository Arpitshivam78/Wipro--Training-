// Remove duplicate elements from a sorted array in c# 

using System;

class Program
{
    static void RemoveDuplicates(int[] arr)
    {
        Array.Sort(arr);
        int unique = 1;

        for (int i = 1; i < arr.Length; i++)
            if (arr[i] != arr[unique - 1])
                arr[unique++] = arr[i];

        Console.WriteLine("Array after removing duplicates:");
        for (int i = 0; i < unique; i++)
            Console.Write(arr[i] + " ");

        Console.WriteLine("\nNumber of unique elements: " + unique);
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 3, 7, 1, 9, 7 };
        RemoveDuplicates(arr);
    }
}
