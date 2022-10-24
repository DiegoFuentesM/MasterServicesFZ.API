using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class OccupationRepository : SqlRepositoryBase<Occupation>, IOccupationRepository
    {
        public OccupationRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
