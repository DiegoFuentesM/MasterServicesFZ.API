using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class InternationalBusinessRepository : RepositoryBase<InternationalBusiness>, IInternationalBusinessRepository
    {
        public InternationalBusinessRepository(PostgresDbContext context) : base(context)
        {
        }
    }
}
