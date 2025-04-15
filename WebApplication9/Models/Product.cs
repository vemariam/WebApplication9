using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [MaxLength(100)]
        public string ProductDescription { get; set; }
        [Required]
        public int ProductStockQuantity { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
