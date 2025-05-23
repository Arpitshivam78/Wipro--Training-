class Program
{
    static void DoWork (object state) 
    {
        Console.WriteLine($"Thread Pool State Started - {state}"); 
        Thread.Sleep (1000);
        Console.WriteLine($"Thread Pool State Finished - {state}");
    }  

    static void Main()
    {
        for (int i = 0;  i < 5; i++)
        {
            ThreadPool.QueueUserWorkItem(DoWork, $"Task - {i}");

            Console.WriteLine($"Main Thread Continues ");
            Thread.Sleep(1000); 
            Console.WriteLine($"Main Thread Ends ");
        }
    }
}