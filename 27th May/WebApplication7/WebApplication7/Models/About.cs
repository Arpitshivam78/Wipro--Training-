using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class About
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Page Title")]
        public string Title { get; set; }

        [StringLength(500)]
        [Display(Name = "Page Description")]
        public string Description { get; set; }

        [Display(Name = "Welcome Message")]
        public string Message { get; set; }
    }
}
