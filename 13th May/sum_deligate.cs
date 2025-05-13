using System;

class SimpleDeligate
{

    public delegate int SomeOperation(int i, int j); 

    class Program
    {
       public static int Sum(int x, int y) 
        { 
            return x + y; 
        } 
    } 

    static void Main(string[] args)
    {
        SomeOperation add = Program.Sum; 
        int result = add(1, 2); 
        Console.WriteLine(result); 
    }
   
}


