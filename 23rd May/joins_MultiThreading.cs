using System.Diagnostics;

class Prgoram
{
    static void DoWork(string Name )
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Thread {Name} - Step {i}");  
            Thread.Sleep(1000);
        } 

    } 
    static void Main()
    {
        Thread t1 = new Thread(() => DoWork("A"));
        Thread t2 = new Thread(() => DoWork("B"));
        Thread t3 = new Thread(() => DoWork("C"));

        t1.Start();
        t1.Join();

        t2.Start();
        t2.Join(); 

        t3.Start();
        t3.Join();


        Console.WriteLine("All Threads are joint in a venture"); 
    }
}