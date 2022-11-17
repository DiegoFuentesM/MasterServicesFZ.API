using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class DepartmentRepository : SqlRepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
