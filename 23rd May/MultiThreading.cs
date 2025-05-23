using System;
using System.Threading;

class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i < 10; i++)
        {
          Console.WriteLine($"Thread: {i}"); 
          Thread.Sleep( 500 );
        } 

    } 

    static void Main()
    {
        Thread myTHread = new Thread(PrintNumbers); 
        myTHread.Start(); 

        for(int i = 1; i < 10; i++)
        {
            Console.WriteLine($"Main : {i}"); Thread.Sleep( 500 ); 
        }
    }
 }

/* 
class Program
{
    static void PrintMessage(object Message)
    {
        string msg = (string) Message; 
        Console.WriteLine("Message" + msg); 
    } 
    static void Main()
    {
        Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
        thread.Start("This is a thread message ");
    }

} 






 
*/ 

/* 
class Prgoram
{
    static void Main()
    {
        int a = 56;
        int b = 78;

        Thread thread = new Thread(() =>
        {
            Console.WriteLine($"Sum {a + b}");
        });
        thread.Start();
    }
} 

*/ 

