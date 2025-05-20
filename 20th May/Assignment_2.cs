using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 201);
            }

            SortingAlgorithms.SelectionSort(arr);

            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(", ", arr));

            int key = arr[random.Next(arr.Length)];
            Console.WriteLine($"\nSearching for: {key}");

            int linearComparisons;
            int linearPos = SearchingAlgorithms.LinearSearch(arr, key, out linearComparisons);

            int binaryComparisons;
            int binaryPos = SearchingAlgorithms.BinarySearch(arr, key, out binaryComparisons);

            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"Linear Search: Position = {linearPos}, Comparisons = {linearComparisons}");
            Console.WriteLine($"Binary Search: Position = {binaryPos}, Comparisons = {binaryComparisons}");

            Console.WriteLine("\nBinary Search is more efficient for large, sorted lists due to its O(log n) time complexity compared to Linear Search's O(n).");
        }
    }

    static class SortingAlgorithms
    {
        public static void SelectionSort(int[] arr)
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
    }

    static class SearchingAlgorithms
    {
        public static int LinearSearch(int[] arr, int key, out int comparisons)
        {
            comparisons = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                comparisons++;
                if (arr[i] == key)
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] arr, int key, out int comparisons)
        {
            comparisons = 0;
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                comparisons++;
                int mid = left + (right - left) / 2;

                if (arr[mid] == key)
                    return mid;
                else if (arr[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
    }
}
