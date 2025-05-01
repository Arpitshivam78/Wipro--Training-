// Exercise 4: Print squares of mumbers untill the square exceeds 100. 

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