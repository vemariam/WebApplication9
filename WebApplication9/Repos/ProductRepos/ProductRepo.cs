using WebApplication9.Data;
using WebApplication9.Dtos.ProductDtos;
using WebApplication9.Models;

namespace WebApplication9.Repos.ProductRepos
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;

        public ProductRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Add(ProductDto product)
        {
            var products = new Product
            {
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                ProductStockQuantity = product.ProductStockQuantity,
            };
            _context.products.Add(products);
            _context.SaveChanges();
            
        }
    }
}
