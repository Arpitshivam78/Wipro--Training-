using System; 
using System.Collections.Generic; 
class Program{ 
         static void Main(){ 

              List<int> numbers = new List<int>(); 

              numbers.Add(1); 
              numbers.Add(2); 
              numbers.Add(3);       
          
          foreach(int num in numbers){ 
                Console.WriteLine(num); 
          }
         }
} 

