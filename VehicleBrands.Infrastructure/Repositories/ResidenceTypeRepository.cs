using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class ResidenceTypeRepository : SqlRepositoryBase<ResidenceType>, IResidenceTypeRepository
    {
        public ResidenceTypeRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
