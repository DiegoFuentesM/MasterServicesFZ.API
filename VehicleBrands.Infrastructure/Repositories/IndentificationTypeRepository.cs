using Infrastructure.Persistence;
using Infrastructure.Repositories;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class IndentificationTypeRepository : RepositoryBase<IdentificactionType>, IIdentificationTypeRepository
    {
        public IndentificationTypeRepository(PostgresDbContext context) : base(context)
        {
        }
    }
}
