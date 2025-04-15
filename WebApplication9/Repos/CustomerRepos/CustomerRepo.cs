using WebApplication9.Data;
using WebApplication9.Dtos.CustomerDtos;
using WebApplication9.Dtos.OrderDtos;
using WebApplication9.Dtos.ProductDtos;
using WebApplication9.Dtos.ShoppingCartDtos;
using WebApplication9.Models;

namespace WebApplication9.Repos.CustomerRepos
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;

        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddCustomer(AddAllCustomerDto customer)
        {
            var customers = new Customer
            {
                CustomerContact = customer.CustomerContact,
                CustomerName = customer.CustomerName,
                CustomerEmail = customer.CustomerEmail,
                ShoppingCart = new ShoppingCart
                { 
                    NumberOfItems = customer.ShoppingCartDto.NumberOfItems,
                },
                Orders = _context.Orders.Select(x=> new Order
                {
                    OrderTotalPrice = x.OrderTotalPrice,
                }).ToList(),
            };
            _context.customers.Add(customers);
            _context.SaveChanges();
        }

        public GetCustomerDto GetCustomerById(int id)
        {
            var customer = _context.customers
                .FirstOrDefault(x=> x.CustomerId == id);
            return new GetCustomerDto
            {
                CustomerContact = customer.CustomerContact,
                CustomerName = customer.CustomerName,
                CustomerEmail = customer.CustomerEmail,
                ShoppingCartDto = new OnlyShoppingCartDto
                {
                    NumberOfItems = customer.ShoppingCart.NumberOfItems,
                },
                Orders = _context.Orders.Select(x=>new OrderProductDto
                {
                    CustomerId = x.CustomerId,
                    OrderTotalPrice= x.OrderTotalPrice,
                    Products = _context.products.Select(x=>new ProductDto
                    {
                        ProductDescription = x.ProductDescription,
                        ProductName = x.ProductName,
                        ProductStockQuantity = x.ProductStockQuantity,
       
                    }).ToList(),
                }).ToList(),

            };
        }
    }
}
