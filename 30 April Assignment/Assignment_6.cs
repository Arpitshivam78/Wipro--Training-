// 2. Count Frequency of Each Element

//For (1, 2, 1, 3, 2, 1), output: 
//1: 3 times, 2: 2 times, 3: 1 time 

using System;

public class Program
{
    public static void Main()
    {
        int[] arr = {1, 2, 3, 4, 5, 67, 8, 9, 10, 3, 2, 1, 3, 2, 1};
        int[] frequency = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            frequency[i] = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    frequency[i]++;
                    frequency[j] = -1; 
                }
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (frequency[i] != -1)
            {
                Console.WriteLine($"{arr[i]} appears {frequency[i]} times");
            }
        }
    }
}
