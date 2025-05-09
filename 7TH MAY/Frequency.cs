//Write a method that takes an integer array and prints the frequency of each element.

//Sample Input: (1, 2, 2, 3, 3, 3) 

//Output: 1 occurs 1 times, 2 occurs 2 times, 3 occurs 3 times 

using System;
using System.Collections.Generic;

class Frequency
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 4 };

        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        foreach (var pair in freq)
        {
            Console.WriteLine(pair.Key + " appears " + pair.Value + " times");
        }
    }
}


