using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    internal class ContractTypeRepository : SqlRepositoryBase<ContractType>, IContractTypeRepository
    {
        public ContractTypeRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
