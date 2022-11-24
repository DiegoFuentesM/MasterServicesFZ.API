using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public
        class MaritalStatusRepository : SqlRepositoryBase<MaritalStatus>, IMaritalStatusRepository
    {
        public MaritalStatusRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
