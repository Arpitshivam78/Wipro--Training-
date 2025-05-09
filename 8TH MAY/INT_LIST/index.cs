using System; 
using System.Collections.Generic; 

class Program
{ 
               static void Main() 
               {
                List<int> numbers = new List<int>{20,30,40,50}; 

                int index = numbers.IndexOf(30); 
                Console.WriteLine("Index of 30:" + index);  

                bool Contains = numbers.Contains(40); 
                Console.WriteLine("List contains 40:" + Contains); 

               }
}