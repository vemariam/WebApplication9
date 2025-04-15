using System.ComponentModel.DataAnnotations;
using WebApplication9.Dtos.ProductDtos;
using WebApplication9.Models;

namespace WebApplication9.Dtos.OrderDtos
{
    public class OrderProductDto
    {
        [Required]
        public int OrderTotalPrice { get; set; }
        public int CustomerId { get; set; }
        public IList<ProductDto> Products { get; set; }
    }
}
