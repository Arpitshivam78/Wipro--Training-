using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "Product name cannot exceed 100 characters.")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [StringLength(1000, ErrorMessage = "Product description cannot exceed 1000 characters.")]
        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Product category is required.")]
        [Display(Name = "Product Category")]
        public string ProductCategory { get; set; }

        [Required(ErrorMessage = "Product category ID is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Product category ID must be a positive integer.")]
        [Display(Name = "Product Category ID")]
        public int ProductCategoryId { get; set; }
    }
}
