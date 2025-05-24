/* 
Thread Pool
📝 Exercise 3: Use ThreadPool to Run Lightweight Tasks
Create a method ProcessItem(object item) that prints a message with a delay.
Use ThreadPool.QueueUserWorkItem to run this for 5 different items.
*/

using Program
{
    static void Main(string[] args)
    {
        ThreadPool.QueueUserWorkItem(ProcessItem, "Item 1");
        ThreadPool.QueueUserWorkItem(ProcessItem, "Item 2");
        ThreadPool.QueueUserWorkItem(ProcessItem, "Item 3");
        ThreadPool.QueueUserWorkItem(ProcessItem, "Item 4");
        ThreadPool.QueueUserWorkItem(ProcessItem, "Item 5");
    }

    static void ProcessItem(object item)
    {
        Console.WriteLine("Processing item: " + item);
        Thread.Sleep(2000);
    } 
    
}