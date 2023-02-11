using CustomerInformation.Infrastructure.DbContexts;
using CustomerInformation.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformation.Infrastructure.UnitOfWorks
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public ICountryRepository Countries { get; private set; }
        public ICustomerRepository Customers { get; private set; }

        public ApplicationUnitOfWork(IApplicationDbContext dbContext, ICountryRepository countryRepository, ICustomerRepository customerRepository) : base((DbContext)dbContext)
        {
            Countries = countryRepository;
            Customers = customers;
        }
    }
}
