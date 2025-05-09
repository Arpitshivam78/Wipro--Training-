using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        products.Add(new Product("Laptop", 80000));
        products.Add(new Product("Mobile", 20000));
        products.Add(new Product("Tablet", 30000));

        Console.WriteLine("Product List:");
        foreach (var product in products)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }
    }
}
