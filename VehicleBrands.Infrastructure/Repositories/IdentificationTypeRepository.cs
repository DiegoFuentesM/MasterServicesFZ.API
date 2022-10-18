using MasterServicesFZ.Infrastructure.Persistence;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class IdentificationTypeRepository : RepositoryBase<IdentificactionType>, IIdentificationTypeRepository
    {
        public IdentificationTypeRepository(PostgresDbContext context) : base(context)
        {
        }
    }
}
