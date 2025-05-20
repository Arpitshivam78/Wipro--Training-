using System;
using System.Diagnostics;

class SortingAlgorithms
{
    static void Main(string[] args)
    {
        // Generate 20 random integers between 1 and 100
        Random rand = new Random();
        int[] original = new int[20];
        for (int i = 0; i < original.Length; i++)
        {
            original[i] = rand.Next(1, 101);
        }

        Console.WriteLine("Original Array:");
        PrintArray(original);

        // Bubble Sort
        int[] bubbleArray = (int[])original.Clone();
        Stopwatch sw1 = Stopwatch.StartNew();
        BubbleSort(bubbleArray);
        sw1.Stop();
        Console.WriteLine("\nBubble Sort:");
        PrintArray(bubbleArray);
        Console.WriteLine("Time: " + sw1.Elapsed.TotalMilliseconds + " ms");

        // Selection Sort
        int[] selectionArray = (int[])original.Clone();
        Stopwatch sw2 = Stopwatch.StartNew();
        SelectionSort(selectionArray);
        sw2.Stop();
        Console.WriteLine("\nSelection Sort:");
        PrintArray(selectionArray);
        Console.WriteLine("Time: " + sw2.Elapsed.TotalMilliseconds + " ms");

        // Insertion Sort
        int[] insertionArray = (int[])original.Clone();
        Stopwatch sw3 = Stopwatch.StartNew();
        InsertionSort(insertionArray);
        sw3.Stop();
        Console.WriteLine("\nInsertion Sort:");
        PrintArray(insertionArray);
        Console.WriteLine("Time: " + sw3.Elapsed.TotalMilliseconds + " ms");
    }

    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}
