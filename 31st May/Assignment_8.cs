/* 
8. Invoice Generator (Interface + Abstraction)
 Concepts: Abstract Class, Interface, Inheritance Task:
 Abstract class 
Invoice with 
CalculateTotal()
 Subclasses for 
RetailInvoice , 
WholesaleInvoice
 Interface 
IPrintable with 
Print()
 Print an invoice with product list, tax, and discount
*/ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice retailInvoice = new RetailInvoice();
            Invoice wholesaleInvoice = new WholesaleInvoice();

            retailInvoice.CalculateTotal();
            wholesaleInvoice.CalculateTotal();

            IPrintable printable = new InvoicePrinter();
            printable.Print(retailInvoice);
            printable.Print(wholesaleInvoice);

            Console.ReadKey();


        }  
         
        
    }
}