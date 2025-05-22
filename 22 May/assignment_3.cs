/* 
Filter products with price > 500 using LINQ.
Instructions:
1. Create a Product class with Name , Price .
2. Create a List<Product> and add 5 items.
3. Use LINQ to filter products where Price > 500 .
4. Display the filtered list. 
*/ 

using System;
using System.Collections.Generic;


namespace Assignment_3
{ 
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Name = "Product 1", Price = 1000 });
            products.Add(new Product { Name = "Product 2", Price = 2000 });
            products.Add(new Product { Name = "Product 3", Price = 3000 });
            products.Add(new Product { Name = "Product 4", Price = 4000 });
            products.Add(new Product { Name = "Product 5", Price = 5000 }); 

            var filteredProducts = products.Where(p => p.Price > 500);

            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}