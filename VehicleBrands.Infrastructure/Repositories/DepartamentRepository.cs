using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class DepartamentRepository : SqlRepositoryBase<Departament>, IDepartamentRepository
    {
        public DepartamentRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
