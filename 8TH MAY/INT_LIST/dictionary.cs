using System; 
using System.Collections.Generic; 

class Program
{ 
         static void Main()
         { 
               Dictionary <int , string> students = new Dictionary<int, string>(); 
                
               students.Add(101, "John"); 
               students.Add(102, "Jane"); 
               students.Add(103, "Sam"); 

            Console.WriteLine("StudenT With ID 102: " + students[102]);  

            foreach (var pair in students)
            { 
                Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}"); 
            }    
         }             
}
