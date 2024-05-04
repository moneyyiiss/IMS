using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Required]
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string Address { get; set; }
    }
}
