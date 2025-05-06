// Recursive Fibonacci - Input: 5 Output: 5,3,2,1,1,2,3,5

using System; 

class Assignment3{ 
        
        static void Main(string[] args){ 
            Console.WriteLine(Fibonacci(5)); 
        }   
        static int Fibonacci(int n){ 
            if (n == 0 || n == 1){ 
                return n; 
            } 
            else{ 
                return Fibonacci (n-1) + Fibonacci (n-2); 
            }
        } 

        }
