using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        [Required]
        public int NumberOfItems { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
