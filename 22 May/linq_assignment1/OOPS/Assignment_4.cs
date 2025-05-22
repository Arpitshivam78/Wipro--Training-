using System;
using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem
{
    // Represents a book in the library
    public class Book
    {
        public int Id { get; set; }           // Unique identifier for the book
        public string Title { get; set; }     // Title of the book
        public string Author { get; set; }    // Author of the book
        public bool IsAvailable { get; set; } // Availability status

        public Book(int id, string title, string author, bool isAvailable = true)
        {
            Id = id;
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
        }
    }

    // Represents the library containing a collection of books
    public class Library
    {
        private List<Book> books = new List<Book>();

        // Adds a new book to the library
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        // Searches for books by author (case-insensitive)
        public List<Book> SearchByAuthor(string author)
        {
            return books
                .Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Searches for books by title (case-insensitive)
        public List<Book> SearchByTitle(string title)
        {
            return books
                .Where(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Displays all books in the library
        public void DisplayAllBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Available: {book.IsAvailable}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new library instance
            Library library = new Library();

            // Add sample books to the library
            library.AddBook(new Book(1, "The Great Gatsby", "F. Scott Fitzgerald"));
            library.AddBook(new Book(2, "To Kill a Mockingbird", "Harper Lee"));
            library.AddBook(new Book(3, "1984", "George Orwell"));
            library.AddBook(new Book(4, "Animal Farm", "George Orwell"));
            library.AddBook(new Book(5, "Pride and Prejudice", "Jane Austen"));

            // Display all books in the library
            Console.WriteLine("All Books in the Library:");
            library.DisplayAllBooks();

            // Search for books by author
            Console.WriteLine("\nEnter author name to search:");
            string authorSearch = Console.ReadLine();
            var booksByAuthor = library.SearchByAuthor(authorSearch);

            Console.WriteLine($"\nBooks by '{authorSearch}':");
            if (booksByAuthor.Any())
            {
                foreach (var book in booksByAuthor)
                {
                    Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Available: {book.IsAvailable}");
                }
            }
            else
            {
                Console.WriteLine("No books found by that author.");
            }

            // Search for books by title
            Console.WriteLine("\nEnter book title to search:");
            string titleSearch = Console.ReadLine();
            var booksByTitle = library.SearchByTitle(titleSearch);

            Console.WriteLine($"\nBooks titled '{titleSearch}':");
            if (booksByTitle.Any())
            {
                foreach (var book in booksByTitle)
                {
                    Console.WriteLine($"ID: {book.Id}, Author: {book.Author}, Available: {book.IsAvailable}");
                }
            }
            else
            {
                Console.WriteLine("No books found with that title.");
            }
        }
    }
}
