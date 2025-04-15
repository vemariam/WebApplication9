using System.ComponentModel.DataAnnotations;
using WebApplication9.Dtos.OrderDtos;
using WebApplication9.Dtos.ShoppingCartDtos;
using WebApplication9.Models;

namespace WebApplication9.Dtos.CustomerDtos
{
    public class AddAllCustomerDto
    {
        [Required]
        public string CustomerName { get; set; }
        [Phone]
        public string CustomerContact { get; set; }
        [EmailAddress]
        public string CustomerEmail { get; set; }
        public IList<OnlyOrderDto> OrdersDto { get; set; }
        public OnlyShoppingCartDto ShoppingCartDto { get; set; }
    }
}
