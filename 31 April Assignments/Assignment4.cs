// Exercise 4:Sum of digits using recursion [1,2,3,4,5,6,7]-1+2+3+......
 

using System; 

public class Assignment4{ 
        
        public static int Sum(int n){ 

            if (n == 0){ 
                return 0; 
            } 
            else{ 
                return (n % 10) + Sum(n/10); 
            }

        } 
        public static void Main(){ 
            Console.WriteLine(Sum(7)); 
        }
}