using System;

class Program
{
    static void SearchElement(int[] arr, int target)
    {
        int index = Array.IndexOf(arr, target);
        Console.WriteLine(index >= 0
            ? $"Element {target} found at index {index}"
            : $"Element {target} not found");
    }

    static void Main()
    {
        int[] numbers = { 3, 5, 6, 7, 8, 9, 10 };
        SearchElement(numbers, 7);
    }
}
