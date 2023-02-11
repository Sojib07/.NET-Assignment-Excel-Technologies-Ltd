using CustomerInformation.Infrastructure.DbContexts;
using CustomerInformation.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformation.Infrastructure.Repositories
{
    public class CountryRepository : Repository<Country, int>, ICountryRepository
    {
        public CountryRepository(IApplicationDbContext context) : base((DbContext)context)
        {
        }
    }
}
