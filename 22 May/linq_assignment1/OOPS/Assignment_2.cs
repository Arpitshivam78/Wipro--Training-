using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_2
{
    // Product class
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    // CartItem class
    class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public double GetTotalPrice()
        {
            return Product.Price * Quantity;
        }
    }

    // ShoppingCart class
    class ShoppingCart
    {
        private List<CartItem> items = new List<CartItem>();

        public void AddItem(Product product, int quantity)
        {
            var existingItem = items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                items.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }

        public void RemoveItem(int productId)
        {
            var item = items.FirstOrDefault(i => i.Product.Id == productId);
            if (item != null)
            {
                items.Remove(item);
            }
        }

        public double GetCartTotal()
        {
            return items.Sum(i => i.GetTotalPrice());
        }

        public void DisplayCart()
        {
            Console.WriteLine("Cart Contents:");
            foreach (var item in items)
            {
                Console.WriteLine($"Product: {item.Product.Name}, Quantity: {item.Quantity}, Total: {item.GetTotalPrice():C}");
            }
            Console.WriteLine($"Total Cart Value: {GetCartTotal():C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create products
            Product product1 = new Product { Id = 1, Name = "Product 1", Price = 1000 };
            Product product2 = new Product { Id = 2, Name = "Product 2", Price = 2000 };
            Product product3 = new Product { Id = 3, Name = "Product 3", Price = 3000 };

            // Create shopping cart
            ShoppingCart cart = new ShoppingCart();

            // Add products to cart
            cart.AddItem(product1, 1);
            cart.AddItem(product2, 2);
            cart.AddItem(product3, 1);

            // Display cart contents and total
            cart.DisplayCart();

            Console.ReadLine();
        }
    }
}
