using System;

class Program 
{ 
    static void SearchElement(int[] arr, int found) 
    { 
        bool isFound = false;

        for (int i = 0; i < arr.Length; i++) 
        { 
            if (arr[i] == found) 
            { 
                Console.WriteLine($"Element {found} found at index {i}"); 
                isFound = true;
                break; 
            } 
        }

        if (!isFound)
        {
            Console.WriteLine($"Element {found} not found");
        }
    } 

    static void Main() 
    { 
        int[] numbers = {3, 5, 6, 7, 8, 9, 10};  
        int found = 7; 
        SearchElement(numbers, found); 
    }  
}
