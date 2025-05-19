/* 
Exercise 3: Queue and Stack - Library Book Management
💡 Problem Statement:
Implement a library book management system using Queue<T> and Stack<T>.
Instructions:
Create a class Book with fields:
Title (string)
Author (string)
Use a Queue<Book> to manage borrowed books:
Add 5 borrowed books to the queue.
Display the next book to be returned.
Remove the book after it is returned.
Use a Stack<Book> to manage newly purchased books:
Add 3 new books to the stack.
Display the last book purchased.
Remove a book after it is processed.
Print the remaining books in both the queue and stack. 
*/

using System;
using System.Collections.Generic; 

namespace Assignment_3
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue<Book> borrowedBooks = new Queue<Book>();
            borrowedBooks.Enqueue(new Book { Title = "Book 1", Author = "Author 1" });
            borrowedBooks.Enqueue(new Book { Title = "Book 2", Author = "Author 2" });
            borrowedBooks.Enqueue(new Book { Title = "Book 3", Author = "Author 3" });
            borrowedBooks.Enqueue(new Book { Title = "Book 4", Author = "Author 4" });
            borrowedBooks.Enqueue(new Book { Title = "Book 5", Author = "Author 5" });

            Stack<Book> newBooks = new Stack<Book>();
            newBooks.Push(new Book { Title = "Book 6", Author = "Author 6" });
            newBooks.Push(new Book { Title = "Book 7", Author = "Author 7" });
            newBooks.Push(new Book { Title = "Book 8", Author = "Author 8" });

            Console.WriteLine("Borrowed Books:");

            foreach (var book in borrowedBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }

            Console.WriteLine("\nNext Book to be Returned:");
            Console.WriteLine($"Title: {borrowedBooks.Peek().Title}, Author: {borrowedBooks.Peek().Author}");

            borrowedBooks.Dequeue();
            Console.WriteLine("\nRemaining Borrowed Books:");
            foreach (var book in borrowedBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }

            Console.WriteLine("\nNew Books:");

            foreach (var book in newBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }

            Console.WriteLine("\nLast Book Purchased:");
            Console.WriteLine($"Title: {newBooks.Peek().Title}, Author: {newBooks.Peek().Author}");

            newBooks.Pop();
            Console.WriteLine("\nRemaining New Books:");
            foreach (var book in newBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }
    }
}
