using System; 

class Program 
{ 
    static void FindPairWithSum(int[] arr, int target ) 
    { 
        for (int i = 0; i <arr.length; i++) 
        { 
            for (int j = i + 1; j < arr.Length; j++) { 
                 
                 if (arr[i] + arr[j] == target) { 
                    Console.WriteLine($"({arr[i]}, {arr[j]}) = {target}");
                 }
            }
        }
    } 
    static void Main() 
    { 
        int[] arr = { 1, 2, 3, 4, 5 }; 
        int target = 6; 
        FindPairWithSum(arr, target); 
    } 
}