using Microsoft.EntityFrameworkCore;

namespace CustomerInformation.Infrastructure.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Country> Countries { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<CustomerAddress> CustomerAddresses { get; set; }
    }
}