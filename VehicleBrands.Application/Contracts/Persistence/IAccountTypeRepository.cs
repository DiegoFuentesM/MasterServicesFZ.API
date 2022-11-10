using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Application.Contracts.Persistence
{
    public interface IAccountTypeRepository : IAsyncRepository<AccountType>
    {
        public Task<List<AccountType>> GetAllActive();
    }
}
