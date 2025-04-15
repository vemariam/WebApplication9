using WebApplication9.Dtos.ProductDtos;

namespace WebApplication9.Repos.ProductRepos
{
    public interface IProductRepo
    {
        public void Add(ProductDto product);
    }
}
