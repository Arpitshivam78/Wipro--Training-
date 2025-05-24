/* 
Exercise 2: Create Multiple Threads and Use Join
Create 3 threads that simulate independent tasks (like printing, computing, or waiting).
Start all threads and use Join() to wait for all to complete before printing “All tasks done”.
*/

using System;
using System.Threading;

namespace Assignment_2
{
    class Program
    {
        Thread thread = new Thread(() => Console.WriteLine("Thread 1")); 
        Thread thread2 = new Thread(() => Console.WriteLine("Thread 2")); 
        Thread thread3 = new Thread(() => Console.WriteLine("Thread 3")); 
        static void Main(string[] args)
        { 
            Program program = new Program(); 
            program.thread.Start(); 
            program.thread2.Start(); 
            program.thread3.Start(); 
            program.thread.Join(); 
            program.thread2.Join(); 
            program.thread3.Join(); 
            Console.WriteLine("All tasks done"); 
        }
    } 
    
}