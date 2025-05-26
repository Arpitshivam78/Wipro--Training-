/* 
 Thread with Dynamic Work Assignment
 Task:
 Start a thread that waits for work via a shared Queue<string>.
 From Main(), enqueue 5 tasks while the thread runs.
 Use lock to synchronize access to the queue.
 Exit when all tasks are processed
*/   

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Queue<string> workQueue = new Queue<string>();
        for (int i = 0; i < 5; i++)
        {
            workQueue.Enqueue("Task " + i);
        }

        Thread workerThread = new Thread(() => ProcessWork(workQueue));
        workerThread.Start();
    }  

    static void ProcessWork(Queue<string> workQueue)
    {
        while (workQueue.Count > 0)
        {
            lock (workQueue)
            {
                string task = workQueue.Dequeue();
                Console.WriteLine("Processing task: " + task);
            }
        }
    }
}