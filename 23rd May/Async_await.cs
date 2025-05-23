using System.Threading.Tasks;

class Prgoram
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Work Started");

        await DoAsyncWork();

        Console.WriteLine("Work Completed");
    }

    static async Task DoAsyncWork()
    {
        Console.WriteLine("Working Constiniously ");
        await Task.Delay(1000);
        Console.WriteLine("Work Done");
    }
}