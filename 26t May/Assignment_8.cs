/* 
8. async/await + Parallel.ForEachAsync – Batch Image Processing
 Task:
 Simulate processing 20 image files using Parallel.ForEachAsync.
 Use await Task.Delay(200ms) per image to simulate processing.
 Print progress percentage in the console
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

class Program
{
    static async Task Main(string[] args)
    {
        List<string> imageFiles = Enumerable.Range(1, 20).Select(i => $"Image_{i}.jpg").ToList();
        int totalImages = imageFiles.Count;

        await Parallel.ForEachAsync(imageFiles, async (image, cancellationToken) =>
        {
            // Simulate image processing
            await Task.Delay(200, cancellationToken);
            int processedIndex = imageFiles.IndexOf(image) + 1;
            Console.WriteLine($"Processed {processedIndex}/{totalImages} - {image}");
        });

        Console.WriteLine("All images processed.");
    }
    static void PrintProgress(int processed, int total)
    {
        double percentage = (double)processed / total * 100;
        Console.WriteLine($"Progress: {percentage:F2}%");
    } 
    
        .Select(group => group.OrderByDescending(item => item.Price).First())
                .ToList();

    Console.WriteLine("Highest Priced Items by Type:");
            foreach (var item in highestPricedItems)
            {
                Console.WriteLine($"Type: {item.Type}, Name: {item.Name}, Stock: {item.Stock}, Price: {item.Price}");
            }
        }
