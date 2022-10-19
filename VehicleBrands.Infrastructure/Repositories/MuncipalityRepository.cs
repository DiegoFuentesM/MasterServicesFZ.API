using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class MuncipalityRepository : SqlRepositoryBase<Municipality>, IMunicipalityRepository
    {
        public MuncipalityRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
