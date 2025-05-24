using System;
using System.Threading.Tasks; 
class Program
{
    static async Task DownloadFileAsync(string filename, int DelayMs)
    {
        Console.WriteLine($"Downloading {filename}");
        await Task.Delay(DelayMs);
        Console.WriteLine($"Downloaded {filename} {DelayMs}");
    }

    static async Task Main(string[] args)
    {
        Task file1 = DownloadFileAsync("File_Pdf", 3000);
        Task file2 = DownloadFileAsync("File_Ppt", 2000);
        Task file3 = DownloadFileAsync("File_Doc", 1000);

        await Task.WhenAll(file1, file2, file3);

        Console.WriteLine("\n All Files Downloaded");

    }
}