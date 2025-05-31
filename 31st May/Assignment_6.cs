/* 
6. Library Management System (OOP + Collections)
 Concepts: Class structure, object list management Task:
 Classes: Book, Student
 Add, delete, and borrow books
 Track who borrowed what and due dates

*/ 

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a library object
        Library library = new Library();

        // Add a book
        library.AddBook("The Great Gatsby", "F. Scott Fitzgerald");

        // Borrow a book
        library.BorrowBook("The Great Gatsby", "John Doe");

        // Return a book
        library.ReturnBook("The Great Gatsby");

        // List all books
        library.ListBooks();
    }

    class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(string title, string author)
        {
            Book book = new Book(title, author);
            books.Add(book);
        }

        public void BorrowBook(string title, string borrower)
        {
            Book book = books.Find(b => b.Title == title);
            if (book != null)
            {
                book.Borrower = borrower;
            }
        }

        public void ReturnBook(string title)
        {
            Book book = books.Find(b => b.Title == title);
            if (book != null)
            {
                book.Borrower = null;
            }
        }

        public void ListBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Borrower: {book.Borrower}");
            }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Borrower { get; set; }
        } 
        
        
    }
}