using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var tasks = new List<Task>
        {
            Task.Run(() => { throw new InvalidOperationException("Task 1 failed"); }),
            Task.Run(() => { throw new ArgumentNullException("Task 2 failed"); }),
            Task.Run(() => Console.WriteLine("Task 3 completed successfully")),
            Task.Run(() => Console.WriteLine("Task 4 completed successfully")),
            Task.Run(() => Console.WriteLine("Task 5 completed successfully"))
        };

        var allTasks = Task.WhenAll(tasks);

        try
        {
            await allTasks;
        }
        catch
        {
            if (allTasks.Exception != null)
            {
                foreach (var ex in allTasks.Exception.InnerExceptions)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        Console.WriteLine("All tasks completed.");
    }
}
