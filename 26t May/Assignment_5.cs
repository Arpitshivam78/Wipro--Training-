/* 
 5. Async Task WhenAny – Fastest Server Simulation
 Task:
 Create 3 async methods simulating responses from different servers (Server1,
 Server2, Server3) with random delay.
 Use Task.WhenAny() to get the fastest.
 Cancel the remaining using CancellationTokenSource.

*/

using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using var cts = new CancellationTokenSource();

        var Task1 = Server1(cts.Token);
        var Task2 = Server2(cts.Token);
        var Task3 = Server3(cts.Token);

        await Task.WhenAny(Task1, Task2, Task3);

        cts.Cancel();

        await Task.WhenAll(Task1, Task2, Task3);
    }

    static async Task Server1(CancellationToken token)
    {
        try
        {
            await Task.Delay(1000, token);
            Console.WriteLine("Server 1 responded.");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Server 1 task was canceled.");
        }
    }

    static async Task Server2(CancellationToken token)
    {
        try
        {
            await Task.Delay(2000, token);
            Console.WriteLine("Server 2 responded.");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Server 2 task was canceled.");
        }
    }

    static async Task Server3(CancellationToken token)
    {
        try
        {
            await Task.Delay(3000, token);
            Console.WriteLine("Server 3 responded.");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Server 3 task was canceled.");
        }
    }
}
