/*  
Async / Await & Tasks
📝 Exercise 4: Simulate Parallel Downloads
Create DownloadFileAsync(string fileName, int delay)
Simulate downloading 3 files in parallel.
Use Task.WhenAll() to await them and print total download time.
*/

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Task file1 = DownloadFileAsync("File_Pdf", 3000);
        Task file2 = DownloadFileAsync("File_Ppt", 2000);
        Task file3 = DownloadFileAsync("File_Doc", 1000);
        Task.WhenAll(file1, file2, file3);
        Console.WriteLine("\n All Files Downloaded");
    }

    static async Task DownloadFileAsync(string filename, int DelayMs)
    {
        Console.WriteLine($"Downloading {filename}");
        await Task.Delay(DelayMs);
        Console.WriteLine($"Downloaded {filename} {DelayMs}");
    } 
    
    
}