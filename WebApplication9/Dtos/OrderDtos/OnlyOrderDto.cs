using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Dtos.OrderDtos
{
    public class OnlyOrderDto
    {
        [Required]
        public int OrderTotalPrice { get; set; }
    }
}
