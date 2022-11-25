using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class InitialPaymentOriginRepository : SqlRepositoryBase<InitialPaymentOrigin>, IInitialPaymentOriginRepository
    {
        public InitialPaymentOriginRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
