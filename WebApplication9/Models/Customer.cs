using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Phone]
        public string CustomerContact {  get; set; }
        [EmailAddress]
        public string CustomerEmail { get; set; }
        public IList<Order> Orders { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

    }
}
