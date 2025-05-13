// using Same problem latest method 

class SimpleDeligate
{

    public delegate int SomeOperation(int i, int j); 

    class Function
    {
       public static int Sum(int x, int y) 
            { return x + y; } 
    }

    static void Main(string[] args)
    {
        Func<int, int, int> add = Function.Sum;   

        int result = add(1, 2); 
        Console.WriteLine(result); 
    }
   
}
