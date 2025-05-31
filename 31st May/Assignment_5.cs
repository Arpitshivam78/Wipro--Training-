/* 
5. String Analyzer Tool (LINQ + String + Dictionary)
 Concepts: String manipulation, LINQ, Dictionary Task:
 Accept a paragraph from user input
 Count:
 Word frequency
 Vowel/consonant count
 Longest and shortest word
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string paragraph = "The quick brown fox jumps over the lazy dog.";
        string[] words = paragraph.Split(' ');
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (wordFrequency.ContainsKey(word))
            {
                wordFrequency[word]++;
            }
            else
            {
                wordFrequency[word] = 1;
            }
        }
        Console.WriteLine("Word frequency:");
        foreach (KeyValuePair<string, int> pair in wordFrequency)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");

        }
        int vowelCount = paragraph.Count(c => "aeiouAEIOU".Contains(c));
        int consonantCount = paragraph.Length - vowelCount;
        Console.WriteLine($"Vowel count: {vowelCount}");
        Console.WriteLine($"Consonant count: {consonantCount}");
        string longestWord = words.Max();
        string shortestWord = words.Min();
        Console.WriteLine($"Longest word: {longestWord}");
        Console.WriteLine($"Shortest word: {shortestWord}");
        
    }
}