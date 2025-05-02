// binary search followes the divide and conquer approach 
// recursively search other half of the array. 

// Recursive factorial - number - 10 [1,2,3,4,5,6,7]

using System; 

class Assignment { 
      
      static int factorial(int n){ 
             if( n == 1){   
                return 1; 
             } 
             else{ 
                return n * factorial(n-1);  
             } 
        } 
        static void Main(string[] args){ 
            Console.WriteLine(factorial(10)); 
        } 

    } 
