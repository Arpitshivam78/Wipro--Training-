// //Exercise 1: Given a month number (1-12), print its name.  


using System; 


class HelloWorld 
{ 
    static int main() 
    { 
        int month = 5; 

        if (month == 1){ 
            Console.WriteLine("January"); 
 
        } 
        elif (month == 2){ 
            Console.WriteLine("February"); 
        } 
        elif (month == 3){ 
            Console.WriteLine("March"); 
        } 
        elif (month == 4){ 
            Console.WriteLine("April"); 
        } 
        elif (month == 5){ 
            Console.WriteLine("May"); 
        } 
        elif (month == 6){ 
            Console.WriteLine("June"); 
        } 
        elif (month == 7){ 
            Console.WriteLine("July"); 
        }
        elif (month == 8){ 
            Console.WriteLine("August"); 
        } 
        elif (month == 9){ 
            Console.WriteLine("September"); 
        } 
        elif (month == 10){ 
            Console.WriteLine("October"); 
        } 
        elif (month == 11){ 
            Console.WriteLine("November"); 
        } 
        elif (month == 12){ 
            Console.WriteLine("December"); 
        } 
        else{ 
            Console.WriteLine("Invalid Month Number:" + month); 
        }
    } 

} 

// print sum using loops: 
using System;

public class HelloWorld
{
    static int Sum(int a, int b)
    {  
        int sum = 0; 

        for (int i = 0; i < a; i++)
        { 
            sum++;
        } 
        
        for (int i = 0; i < b; i++)
        { 
            sum++;
        }  

        return sum; 
    }  
    
    static void Main(string[] args)
    { 
        int result = Sum(65, 67);
        Console.WriteLine("The sum is: " + result); 
    }
}

// // Exercise 3: Reverse a number (e.g., 123321).

using System; 

class Reverse{ 
         static void Main(string[] args){ 
            int = 123321; 
            int reversed = 0;  

            whilr(i > 0){ 
                int digit = i % 10; // get the last digit 
                reversed = Reverse * 10 + digit; // add the last digit to the reversed number 
                i = i / 10; // remove the last digit 
            } 

            Console.WriteLine("Reversed number: " + reversed);  

         }
} 

// print squares of numbers untill the square exceeds 100. 

using System; 

class HelloWorld{ 
      static void Main(string[] args){ 

        int i = 1; 
        int square = 0; 

        while(square < 100){ 
            square = i * i; 
            Console.WriteLine("This square of the numbers is :" + square); 
            i++; 
        }
      }
} 

// 2. Count Frequency of Each Element

//For (1, 2, 1, 3, 2, 1), output: 
//1: 3 times, 2: 2 times, 3: 1 time  

using System;

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
