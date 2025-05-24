/* 
Exercise 1: Start, Pause, Resume, and Stop a Thread
Create a thread that prints numbers from 1 to 100.
Use bool pause and bool stop flags to control the behavior.
From Main(), pause for a few seconds, resume, then stop the thread.
Use ThreadState to log status.

*/

using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread = new Thread(() =>
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Thread: {i}");
                Thread.Sleep(100);
            }
        });
        thread.Start();

        Console.WriteLine("Press Enter to pause the thread...");
        Console.ReadLine();

        thread.Suspend();

        Console.WriteLine("Press Enter to resume the thread...");
        Console.ReadLine();

        thread.Resume();

        Console.WriteLine("Press Enter to stop the thread...");
        Console.ReadLine();

        thread.Abort();
    } 
    

} 

