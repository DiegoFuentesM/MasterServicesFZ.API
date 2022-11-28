using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    internal class GoodTypeRepository : RepositoryBase<GoodType>, IGoodTypeRepository
    {
        public GoodTypeRepository(PostgresDbContext context) : base(context)
        {
        }
    }
}
