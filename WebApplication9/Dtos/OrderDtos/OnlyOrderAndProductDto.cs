using System.ComponentModel.DataAnnotations;
using WebApplication9.Dtos.CustomerDtos;
using WebApplication9.Dtos.ProductDtos;

namespace WebApplication9.Dtos.OrderDtos
{
    public class OnlyOrderAndProductDto
    {
        [Required]
        public int OrderTotalPrice { get; set; }
        public IList<ProductDto> Products { get; set; }
    }
}
