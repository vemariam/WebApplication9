using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Dtos.CustomerDtos
{
    public class OnlyCustomerDto
    {
        [Required]
        public string CustomerName { get; set; }
        [Phone]
        public string CustomerContact { get; set; }
        [EmailAddress]
        public string CustomerEmail { get; set; }
    }
}
