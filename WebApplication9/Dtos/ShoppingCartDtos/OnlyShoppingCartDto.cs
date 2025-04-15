using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Dtos.ShoppingCartDtos
{
    public class OnlyShoppingCartDto
    {
        [Required]
        public int NumberOfItems { get; set; }
    }
}
