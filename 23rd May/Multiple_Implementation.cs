class Program
{
    static bool pause = false;
    static bool stop = false;

    static void DoWork()
    {
        while (!stop)
        {
            if (pause)
            {
                Console.WriteLine("Working ...");
                Thread.Sleep(1000);
                continue;
            }

            Console.WriteLine("Working ...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Stopped"); 
    }
    static void Main()
    {
        Thread worker = new Thread(DoWork);

        Console.WriteLine("Initital Thread State" + worker.ThreadState);

        worker.Start();

        Thread.Sleep(3000);
        pause = true;
        Console.WriteLine("Thread Paused" + worker.ThreadState);

        Thread.Sleep(3000);
        pause = false;
        Console.WriteLine("Resume Working" + worker.ThreadState);

        Thread.Sleep(3000);
        stop = true;
        Console.WriteLine("Thread Stopped" + worker.ThreadState);

        worker.Join(); 

        Console.WriteLine("Final Thread State" + worker.ThreadState); 
        }
    }
