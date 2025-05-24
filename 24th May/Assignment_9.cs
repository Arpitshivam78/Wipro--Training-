/*
Exercise 9: Cancellation Using CancellationToken
Create DoWorkAsync(CancellationToken token)
Cancel the task from Main() after 2 seconds.
Handle cancellation and print a message.
*/  

using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        cts.CancelAfter(2000);

        DoWorkAsync(cts.Token).Wait();

        cts.Dispose();

        Console.WriteLine("All tasks done");

        static async Task DoWorkAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                Console.WriteLine("Working...");
                await Task.Delay(1000);
            }
        } 
        
        
    }
}