using System.Collections.ObjectModel;

namespace WebApplication3.Models
{
    public class Product
    {
     

        

            public int ProductId { get; set; }

            public string ProductName { get; set; }

            public decimal Price { get; set; }

            public Category Categories { get; set; } // Navigation Property

            public class Category

            {

                public int CategoryId { get; set; }

                public string CategoryName { get; set; }

                public Collection<Product> Products { get; set; } // Navigation Property

            }

        }
    }

