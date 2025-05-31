/*
 4. Multithreading File Processor
 Concepts: Threads, Lock, File Handling Task:
 Create threads to read 3 large files in parallel
 Use Thread.Join() to ensure all are read
 Count total lines across all files
*/ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        

        Thread t1 = new Thread(() => DoWork("A"));
        Thread t2 = new Thread(() => DoWork("B"));
        Thread t3 = new Thread(() => DoWork("C"));

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("Total lines: " + totalLines);

        Console.ReadKey();

        void DoWork(string filename)
        {
            string[] lines = File.ReadAllLines(filename + ".txt");
            totalLines += lines.Length;
        }

        int totalLines = 0; 



    }
}