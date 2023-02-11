using CustomerInformation.Infrastructure.DbContexts;
using CustomerInformation.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformation.Infrastructure.Repositories
{
    public class CustomerAddressRepository : Repository<CustomerAddress, int>, ICustomerAddressRepository
    {
        public CustomerAddressRepository(IApplicationDbContext context) : base((DbContext)context)
        {
        }
    }
}
