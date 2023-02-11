using CustomerInformation.Infrastructure.Repositories;

namespace CustomerInformation.Infrastructure.UnitOfWorks
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        ICountryRepository Countries { get; }
        public ICustomerRepository Customers { get; }
        public ICustomerAddressRepository CustomerAddress { get; }
    }
}