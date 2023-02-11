using CustomerInformation.Infrastructure.BusinessObjects;

namespace CustomerInformation.Infrastructure.Repositories
{
    public interface ICountryRepository : IRepository<Country, int>
    {
    }
}
