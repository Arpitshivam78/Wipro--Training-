/* 
 9. Async Weather Fetcher (async/await + Task.Delay)
 Concepts: async/await, Task.WhenAll Task:
 Simulate calling weather APIs for 3 cities
 Use 
Task.Delay to mimic delay
 Fetch all concurrently and print total time taken
*/ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    class Program
    {
        static void Main()
        {
            
            static async Task Main(string[] args)
            {
                
                Task<string> task1 = FetchWeatherAsync("City A");
                Task<string> task2 = FetchWeatherAsync("City B");
                Task<string> task3 = FetchWeatherAsync("City C");

                
                var results = await Task.WhenAll(task1, task2, task3);

                Console.WriteLine("Total time taken: " + (DateTime.Now - startTime).TotalMilliseconds + "ms");

                Console.WriteLine("Weather for City A: " + results[0]);
                Console.WriteLine("Weather for City B: " + results[1]);
                Console.WriteLine("Weather for City C: " + results[2]);

                

            } 
                
        }
    }
} 
