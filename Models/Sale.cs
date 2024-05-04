using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public int? OrderId { get; set; }

        [DataType(DataType.Date)]
        public DateTime SaleDate { get; set; }
        [DataType(DataType.Currency)]
        public decimal TotalAmount { get; set; }

        public Order? Order { get; set; }
    }
}
