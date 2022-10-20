using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class FeeRepository : RepositoryBase<Fee>, IFeeRepository
    {
        public FeeRepository(PostgresDbContext context) : base(context)
        {
        }
    }
}
