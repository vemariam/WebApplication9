using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Dtos.ProductDtos
{
    public class ProductDto
    {
        [Required]
        public string ProductName { get; set; }
        [MaxLength(100)]
        public string ProductDescription { get; set; }
        [Required]
        public int ProductStockQuantity { get; set; }
    }
}
