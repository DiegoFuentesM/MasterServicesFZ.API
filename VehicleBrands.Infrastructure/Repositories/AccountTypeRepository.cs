using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class AccountTypeRepository : CreditProductsRepositoryBase<AccountType>, IAccountTypeRepository
    {
        public AccountTypeRepository(CreditProductsDbContext context) : base(context)
        {
        }

        public async Task<List<AccountType>> GetAllActive()
        {
            return await _context.TiposCuenta.Where(x => x.Activo).OrderBy(x => x.Nombre).ToListAsync();
        }
    }
}
