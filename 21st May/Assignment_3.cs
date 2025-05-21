/* 
Problem Statement:
Find the first non-repeating character in a string using hashing.
Instructions:
1. Input:
A string (e.g., "swiss" )
2. Output:
The first character that appears only once (e.g., 'w' )
3. Hint:
Use a Dictionary<char, int> to count frequencies
Loop again to find the first char with frequency 1 
*/ 

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = "swiss";
        char firstNonRepeatingChar = FindFirstNonRepeatingChar(input);
        Console.WriteLine($"First non-repeating character: {firstNonRepeatingChar}");
    }

    static char FindFirstNonRepeatingChar(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        foreach (char c in input)
        {
            if (charCount[c] == 1)
            {
                return c;
            }
        }

        return '\0';
    }
} 
