using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.Dtos.CustomerDtos;
using WebApplication9.Repos.CustomerRepos;

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomersController(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
        [HttpPost]
        public IActionResult Add(AddAllCustomerDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            else
            {
                _customerRepo.AddCustomer(dto);
                return Ok();
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return Ok(_customerRepo.GetCustomerById(id));
        }
    }
}

