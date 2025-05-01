// 2. Count Frequency of Each Element

//For (1, 2, 1, 3, 2, 1), output: 
//1: 3 times, 2: 2 times, 3: 1 time 

class Element
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 1, 3, 2, 1 };
        int n = arr.Length;
        int uniqueCount = 0;

        for (int i = 0; i < n; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < uniqueCount; j++)
            {
                if (arr[i] == arr[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                arr[uniqueCount] = arr[i]; // keep unique element
                uniqueCount++;
            }
        }

        Console.WriteLine("Array after removing duplicates:");
        for (int i = 0; i < uniqueCount; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("\nNumber of unique elements: " + uniqueCount);
    }
}
