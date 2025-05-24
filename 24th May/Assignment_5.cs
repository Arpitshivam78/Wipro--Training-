/* 
Exercise 5: Async Method Returning a Value
Create GetTemperatureAsync(string city) that returns a random temp after delay.
In Main(), call it for 3 cities and print the result.
*/

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine(await GetTemperatureAsync("New York"));
        Console.WriteLine(await GetTemperatureAsync("London"));
        Console.WriteLine(await GetTemperatureAsync("Tokyo"));
    }

    static async Task<int> GetTemperatureAsync(string city)
    {

        await Task.Delay(500); 
        return new Random().Next(0, 100);
    }
}
