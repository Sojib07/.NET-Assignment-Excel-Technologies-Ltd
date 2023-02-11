using CustomerInformation.Infrastructure.Entities;

namespace CustomerInformation.Infrastructure.Repositories
{
    public interface ICustomerAddressRepository : IRepository<CustomerAddress, int>
    {
    }
}
