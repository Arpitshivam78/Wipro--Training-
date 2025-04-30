// Remove duplicate elements from a sorted array in c# 

using System;

class Program
{
    static void RemoveDuplicates(int[] arr)
    {

        Array.Sort(arr);

        int UniqueCount = 0;

    
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0 || arr[i] != arr[i - 1])
            {
                arr[UniqueCount] = arr[i];
                UniqueCount++;
            }
        }

        for (int i = UniqueCount; i < arr.Length; i++)
        {
            arr[i] = 0;
        }

        
        Console.WriteLine("Array after removing duplicates: ");
        for (int i = 0; i < UniqueCount; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Number of unique elements: " + UniqueCount);
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 3, 7, 1, 9, 7 };
        RemoveDuplicates(arr);
    }
}
