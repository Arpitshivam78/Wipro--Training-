/* 
 Custom Collection Filter with LINQ – Inventory System
 Task:
 Create an Item class with Name, Type, Stock, Price.
 Add 15 items to List<Item>.
 Use LINQ to:
 Filter low stock items
 Group by Type
 Find highest priced item in each group
*/

using System;
using System.Collection.Generic;

using System.Linq; 

namespace InventorySystem
{
    // Define the Item class with properties Name, Type, Stock, and Price
    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of items
            List<Item> items = new List<Item>();
            items.Add(new Item { Name = "Item1", Type = "Electronics", Stock = 5, Price = 100.00m });
            items.Add(new Item { Name = "Item2", Type = "Electronics", Stock = 2, Price = 150.00m });
            items.Add(new Item { Name = "Item3", Type = "Clothing", Stock = 10, Price = 50.00m });
            items.Add(new Item { Name = "Item4", Type = "Clothing", Stock = 1, Price = 75.00m });
            items.Add(new Item { Name = "Item5", Type = "Groceries", Stock = 20, Price = 10.00m });
            items.Add(new Item { Name = "Item6", Type = "Groceries", Stock = 3, Price = 15.00m });
            items.Add(new Item { Name = "Item7", Type = "Electronics", Stock = 0, Price = 200.00m });
            items.Add(new Item { Name = "Item8", Type = "Clothing", Stock = 8, Price = 60.00m });
            items.Add(new Item { Name = "Item9", Type = "Groceries", Stock = 5, Price = 12.00m });
            items.Add(new Item { Name = "Item10", Type = "Electronics", Stock = 4, Price = 120.00m });
            items.Add(new Item { Name = "Item11", Type = "Clothing", Stock = 6, Price = 55.00m });
            items.Add(new Item { Name = "Item12", Type = "Groceries", Stock = 15, Price = 8.00m });
            items.Add(new Item { Name = "Item13", Type = "Electronics", Stock = 1, Price = 300.00m });
            items.Add(new Item { Name = "Item14", Type = "Clothing", Stock = 0, Price = 70.00m });
            items.Add(new Item { Name = "Item15", Type = "Groceries", Stock = 7, Price = 20.00m });

            // Filter low stock items (Stock < 5) using LINQ 

            var lowStockItems = items.Where(item => item.Stock < 5).ToList();
            Console.WriteLine("Low Stock Items:");
            foreach (var item in lowStockItems)
            {
                Console.WriteLine($"Name: {item.Name}, Type: {item.Type}, Stock: {item.Stock}, Price: {item.Price}");
            }
            Console.WriteLine();
            // Group items by Type and find the highest priced item in each group using LINQ  
            var highestPricedItems = items
                .GroupBy(item => item.Type)
                .Select(group => new
                {
                    Type = group.Key,
                    HighestPricedItem = group.OrderByDescending(item => item.Price).FirstOrDefault()
                });
            Console.WriteLine("Highest Priced Item in Each Group:");
            foreach (var group in highestPricedItems)
            {
                Console.WriteLine($"Type: {group.Type}, Highest Priced Item: {group.HighestPricedItem.Name}, Price: {group.HighestPricedItem.Price}");
            }
            Console.WriteLine(); 
            
            
        }
    }