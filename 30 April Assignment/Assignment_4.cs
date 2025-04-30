// Exercise 4: Print squares of mumbers untill the square exceeds 100. 

using System; 

class HelloWorld
{ 
    public static void Main(string[] args)
    {   
        int i = 1; 

        int square = 0; 
        while(square < 100)
        { 
          square = i * i; 
            Console.WriteLine(square); 
            i++; 
        } 


    }

}