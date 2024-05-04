using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string Description { get; set; }

        // Navigation property to Category
        public Category? Category { get; set; } // This ensures you can access the Category directly from a Product
    }
}
