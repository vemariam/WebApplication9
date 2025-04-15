using WebApplication9.Dtos.CustomerDtos;

namespace WebApplication9.Repos.CustomerRepos
{
    public interface ICustomerRepo
    {
        public void AddCustomer(AddAllCustomerDto customer);
        public GetCustomerDto GetCustomerById(int id);
    }
}
