/* 
 Exercise 5: List of Objects – Sort Products by Price (Descending)
 Problem:
 Sort products by price using LINQ.
 Instructions:
 1. Create a 
Product class with 
Id , 
Name , 
Price .
 2. Add 5–6 products to a list.
 3. Sort the products by price in descending order using LINQ.
 4. Print the sorted list.
*/ 

using System;
using System.Collections.Generic;

namespace Assignment_5
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Id = 1, Name = "Product 1", Price = 1000 });
            products.Add(new Product { Id = 2, Name = "Product 2", Price = 2000 });
            products.Add(new Product { Id = 3, Name = "Product 3", Price = 3000 });
            products.Add(new Product { Id = 4, Name = "Product 4", Price = 4000 });
            products.Add(new Product { Id = 5, Name = "Product 5", Price = 5000 });
            products.Add(new Product { Id = 6, Name = "Product 6", Price = 6000 });

            var sortedProducts = products.OrderByDescending(p => p.Price);

            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
