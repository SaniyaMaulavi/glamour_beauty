using System.ComponentModel.DataAnnotations;

namespace BeautyParlour.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(0.01, 10000, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; }

        public string ImageUrl { get; set; }

        [Range(0, 1000, ErrorMessage = "Stock must be between 0 and 1000")]
        public int StockQuantity { get; set; }

        public bool IsAvailable { get; set; } = true;
    }
}
