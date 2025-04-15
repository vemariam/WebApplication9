using Microsoft.EntityFrameworkCore;
using WebApplication9.Data;
using WebApplication9.Dtos.CustomerDtos;
using WebApplication9.Dtos.OrderDtos;
using WebApplication9.Dtos.ProductDtos;
using WebApplication9.Models;

namespace WebApplication9.Repos.OrderRepos
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext _context;

        public OrderRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Add(OrderProductDto orderProductDto)
        {
            var customerid = _context.customers
                .FirstOrDefault(x => x.CustomerId == orderProductDto.CustomerId);
            if (customerid != null)
            {
                var orderProduct = new Order
                {
                    OrderTotalPrice = orderProductDto.OrderTotalPrice,
                    Products = _context.products.Select(x => new Product
                    {
                        ProductDescription = x.ProductDescription,
                        ProductName = x.ProductName,
                        ProductStockQuantity = x.ProductStockQuantity,
                    }).ToList(),
                    CustomerId = orderProductDto.CustomerId,
                };
                _context.Orders.Add(orderProduct);
                _context.SaveChanges();
            }
           
        }

        public void Delete(int id)
        {
            var order = _context.Orders.FirstOrDefault(x=>x.OrderId == id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
            return;
        }

        public IList<OrderCustomerDto> GetOrders()
        {
            var orders = _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Products)
                .Select(o => new OrderCustomerDto
                {
                    OrderTotalPrice = o.OrderTotalPrice,
                    Products = _context.products.Select(x => new ProductDto
                    {
                        ProductDescription = x.ProductDescription,
                        ProductName = x.ProductName,
                        ProductStockQuantity = x.ProductStockQuantity,
                    }).ToList(),
                    CustomerDto = new OnlyCustomerDto
                    {
                        CustomerContact = o.Customer.CustomerContact,
                        CustomerName = o.Customer.CustomerName,
                        CustomerEmail = o.Customer.CustomerEmail,
                    }
                }).ToList();
            return orders;
        }

        public void Update(OnlyOrderAndProductDto orderProductDto,int id)
        {
            var existingorder = _context.Orders.FirstOrDefault(x => x.OrderId == id);
            if (existingorder == null)
            {
                return;
            }
            orderProductDto.OrderTotalPrice = existingorder.OrderTotalPrice;
            orderProductDto.Products = _context.products.Select(x=>new ProductDto
            {
                ProductDescription=x.ProductDescription,
                ProductName = x.ProductName,
                ProductStockQuantity = x.ProductStockQuantity,
            }).ToList();
            _context.Orders.Update(existingorder);
            _context.SaveChanges();
        }
    }
}
