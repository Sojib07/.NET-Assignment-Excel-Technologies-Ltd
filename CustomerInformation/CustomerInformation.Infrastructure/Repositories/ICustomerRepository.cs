using CustomerInformation.Infrastructure.Entities;

namespace CustomerInformation.Infrastructure.Repositories
{
    public interface ICustomerRepository : IRepository<Customer, int>
    {
    }
}
