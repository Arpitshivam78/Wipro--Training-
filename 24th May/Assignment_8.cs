/* 
Exercise 8: Exception Handling in Async Code
Create RiskyTaskAsync(string name) where one of them throws an exception.
Use try/catch around Task.WhenAll() and print which task failed.

*/ 

using System;
using System.Threading.Tasks;

class Program
{
    static async Task RiskyTaskAsync(string name)
    {
        Console.WriteLine($"{name} started.");
        await Task.Delay(1000);
        if (name == "Task 2")
        {
            throw new Exception($"{name} encountered an error.");
        }
        Console.WriteLine($"{name} completed successfully.");
    }

    static async Task Main()
    {
        Task task1 = RiskyTaskAsync("Task 1");
        Task task2 = RiskyTaskAsync("Task 2");
        Task task3 = RiskyTaskAsync("Task 3");

        Task allTasks = Task.WhenAll(task1, task2, task3);

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
                    Console.WriteLine($"Task failed: {ex.Message}");
                }
            }
        }

        Console.WriteLine("All tasks completed.");
    }
}
