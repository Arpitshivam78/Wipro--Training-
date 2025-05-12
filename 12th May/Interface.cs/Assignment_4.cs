/* 
     Exercise 3: Abstract Class - Library System

Problem Statement:

Create an abstract class to manage books in a library.

Instructions:

1. Create an abstract class Book with:

An abstract method: Read()

A concrete method: Getinfo() to print "This is a book"

2. Create derived classes:

FictionBook: Implements Read() to print "Reading a fiction book"

ScienceBook: Implements Read() to print "Reading a science book"

3. In the Main() method:

Create objects of FictionBook and ScienceBook using the Book reference.

Call GetInfo() and Read() for both objects.
*/  


using System; 

interface book 
{ 
    void Read();
    void GetInfo(); 
} 

class fictionbook : book 
{ 
    public void Read() 
    { 
     Console.WriteLine("Reading a fiction book"); 
    } 

    public void GetInfo() 
    { 
        Console.WriteLine("This is a book"); 
    }  


} 

class ScienceBook : book 
{ 
    public void Read() 
    { 
        Console.WriteLine("Reading a science book"); 
    } 

    public void GetInfo() 
    { 
        Console.WriteLine("This is a book"); 
    }
} 

class Program 
{ 
    static void Main() 
    { 
        book fiction = new fictionbook(); 
        fiction.GetInfo(); 
        fiction.Read(); 

        book science = new ScienceBook(); 
        science.GetInfo(); 
        science.Read(); 
    }
}