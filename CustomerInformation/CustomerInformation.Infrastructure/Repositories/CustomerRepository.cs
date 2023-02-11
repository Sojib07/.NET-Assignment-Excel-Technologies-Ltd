using CustomerInformation.Infrastructure.DbContexts;
using CustomerInformation.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformation.Infrastructure.Repositories
{
    public class CustomerRepository : Repository<Customer, int>, ICustomerRepository
    {
        public CustomerRepository(IApplicationDbContext context) : base((DbContext)context)
        {
        }
    }
}
