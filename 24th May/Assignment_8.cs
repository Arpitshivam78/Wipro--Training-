/* 
Exercise 8: Exception Handling in Async Code
Create RiskyTaskAsync(string name) where one of them throws an exception.
Use try/catch around Task.WhenAll() and print which task failed.

*/ 

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task task1 = RiskyTaskAsync("Task 1");
        Task task2 = RiskyTaskAsync("Task 2");
        Task task3 = RiskyTaskAsync("Task 3");

        try
        {
            await Task.WhenAll(task1, task2, task3);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Task failed: {ex.Message}");
        }  
        
        Console.WriteLine("All tasks completed."); 
    }
}