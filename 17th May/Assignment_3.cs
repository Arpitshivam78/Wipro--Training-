/* 
Exercise 3: Abstract Class - Document Management
💡 Problem Statement:
Create an abstract class to manage different document types.
Instructions:
Create an abstract class Document with:
An abstract method: PrintContent()
A concrete method: ShowDocumentType() to print "Document Type: [Type]"
Create derived classes:
WordDocument: Implements PrintContent() to print "Printing Word document"
PDFDocument: Implements PrintContent() to print "Printing PDF document"
In the Main() method:
Create objects of both classes using the Document reference.
Call ShowDocumentType() and PrintContent() for both objects. 

*/ 

using System;
using System.Collections.Generic;

using System.Linq;

abstract class Document
{
    public virtual void ShowDocumentType()
    {
        Console.WriteLine($"Document Type: {GetType().Name}");
    }

    public abstract void PrintContent();
}

class WordDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing Word Document");
    }
}

class PDFDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing PDF Document");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Document wordDocument = new WordDocument();
        Document pdfDocument = new PDFDocument();

        wordDocument.ShowDocumentType();
        wordDocument.PrintContent();

        pdfDocument.ShowDocumentType();
        pdfDocument.PrintContent();
    }
}
