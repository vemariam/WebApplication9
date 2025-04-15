using WebApplication9.Dtos.OrderDtos;

namespace WebApplication9.Repos.OrderRepos
{
    public interface IOrderRepo
    {
        public IList<OrderCustomerDto> GetOrders();
        public void Add(OrderProductDto orderProductDto);
        public void Update(OnlyOrderAndProductDto orderProductDto, int id);
        public void Delete(int id);
    }
}
