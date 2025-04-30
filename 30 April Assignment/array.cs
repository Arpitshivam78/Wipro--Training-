using System; 

class Program
{ 
   static void PrintArray(int[] arr)
   { 
       for (int i = 0; i < arr.Length; i ++ )
       { 
            Console.WriteLine($"Element {i + 1}: {arr[i]}");
       } 
      
       
   }       
   static void Main() 
   { 
       int[] numbers = {10,20,30,40,50}; 
       PrintArray(numbers); 
   }
       
}   

// Same logic in reveese order 


using System;

class Program
{
    static void PrintArray(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Element {i + 1}: {arr[i]}");
        }
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        PrintArray(numbers);
    }
}

// 1. Search for an Element (Linear Search)
//. Search for a given number in an array and print its index if found, else print "Not found".
//[3,5,7,8,2,9,10]
//Input: 7
//Output: 2 

using System;  

