using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required]
        public int OrderTotalPrice { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public IList<Product> Products { get; set; }
    }
}
