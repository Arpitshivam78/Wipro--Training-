using System; 

class sum{  
    static void Main(string[] args){ 
        
            int num = Convert.ToInt32(Console.ReadLine()); 
            int sum = 0; 
            while (num > 0) { 
              int rem = num % 10; 
              sum = sum + rem; 
              num = num / 10; 
            } 
            Console.WriteLine(sum); 
    } 
}    