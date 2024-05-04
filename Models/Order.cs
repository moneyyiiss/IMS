using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int? ProductId { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } // e.g., Pending, Completed, Cancelled

        public Product? Product { get; set; }
    }
}
