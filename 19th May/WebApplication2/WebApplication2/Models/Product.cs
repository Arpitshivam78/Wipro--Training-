namespace WebApplication2.Models
{
    public class Product
    { 
        public int ProductID { get; set; } 
        public string ProductName { get; set; } 

        public decimal Price { get; set; } 

       // public Category Category { get; set; }  
    }

    /*public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }

    } 
    */  

}
