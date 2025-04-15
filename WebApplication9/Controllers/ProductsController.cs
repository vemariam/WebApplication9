using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.Dtos.ProductDtos;
using WebApplication9.Repos.ProductRepos;

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepo _productRepo;

        public ProductsController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        [HttpPost]
        public IActionResult Add(ProductDto productDto)
        {
            if (productDto == null)
            {
                return BadRequest();
            }
            else
            {
                _productRepo.Add(productDto);
                return Ok();
            }
        }
    }
}
