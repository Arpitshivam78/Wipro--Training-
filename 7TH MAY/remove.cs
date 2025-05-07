using System; 
using System.Collections; 
class Program{ 
      static void Main(){ 
          ArrayList list = new ArrayList(); 
          list.Add("Apple"); 
          list.Add(42); 
          list.Add(3.14); 
          
          list.Remove(42); 
          list.Remove(3.14); 
          Console.WriteLine("Element is removed " + list.Count); 
           
          
         foreach (var item in list){ 
                Console.WriteLine(item); 
         }  
         Console.Read(); 
      }
} 