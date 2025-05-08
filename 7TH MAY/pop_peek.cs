using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> books = new Stack<string>();
        books.Push("Amit");
        books.Push("Ravi");
        books.Push("Neha");
        books.Push("Priya");

        Console.WriteLine("Books in the stack:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nPopped: " + books.Pop());
        Console.WriteLine("Next in the stack: " + books.Peek());
    }
}
