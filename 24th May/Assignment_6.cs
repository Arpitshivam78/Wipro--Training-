/* 
Exercise 6: Use Task.WhenAny()
Create 3 tasks with different delays.
Use Task.WhenAny() to find which one finishes first and print its name. 

*/

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task task1 = Task.Delay(1000);
        Task task2 = Task.Delay(2000);
        Task task3 = Task.Delay(3000);

        Task completedTask = await Task.WhenAny(task1, task2, task3);

        if (completedTask == task1)
        {
            Console.WriteLine("Task 1 finished first.");
        }
        else if (completedTask == task2)
        {
            Console.WriteLine("Task 2 finished first.");
        }
        else if (completedTask == task3)
        {
            Console.WriteLine("Task 3 finished first.");
        }
    }
}
