using CustomerInformation.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformation.Infrastructure.UnitOfWorks
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        //public ICourseRepository Courses { get; private set; }

        public ApplicationUnitOfWork(IApplicationDbContext dbContext) : base((DbContext)dbContext)
        {

        }
    }
}
