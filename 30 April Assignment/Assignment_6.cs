// 2. Count Frequency of Each Element

//For (1, 2, 1, 3, 2, 1), output: 
//1: 3 times, 2: 2 times, 3: 1 time 

using System;
using System.Collections.Generic;

class Program
{
    static void RemoveDuplicates(int[] arr)
    {
        HashSet<int> uniqueSet = new HashSet<int>(arr);

        Console.WriteLine("Array after removing duplicates:");
        foreach (int num in uniqueSet)
            Console.Write(num + " ");

        Console.WriteLine("\nNumber of unique elements: " + uniqueSet.Count);
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 3, 7, 1, 9, 7 };
        RemoveDuplicates(arr);
    }
}
