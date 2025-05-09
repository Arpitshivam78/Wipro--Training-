using System; 
using System.Collections; 

class Program{ 
        static void Main() { 
            ArrayList numbers = new ArrayList() {4,1,8,3}; 
            numbers.Sort(); 
            Console.WriteLine("Sorted List:"); 
            foreach (var item in numbers){ 
                Console.WriteLine(item); 
            }         

            numbers.Reverse(); 
            Console.WriteLine("Reversed List:"); 
            foreach (var item in  numbers ){ 
                Console.WriteLine(item); 
            }         
                 
        }
}