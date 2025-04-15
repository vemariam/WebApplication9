using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.Dtos.OrderDtos;
using WebApplication9.Repos.OrderRepos;

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepo _order;

        public OrdersController(IOrderRepo order)
        {
            _order = order;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_order.GetOrders());
        }
        [HttpPost]
        public IActionResult Add(OrderProductDto orderProductDto)
        {
            if (orderProductDto == null)
            {
                return BadRequest();
            }
            else
            {
                _order.Add(orderProductDto);
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult Update(OnlyOrderAndProductDto orderProductDto, int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else
            {
                _order.Update(orderProductDto, id);
                return Ok();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            _order.Delete(id);
            return Ok();
        }
    }
}
