using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class ProfessionRepository : RepositoryBase<Profession>, IProfessionRepository
    {
        public ProfessionRepository(PostgresDbContext context) : base(context)
        {
        }

        public async Task<List<Profession>> GetAllProfessionsQuery ()
        {
            var professions = await _context.m_profesion!.Where(p => p.activo == true && p.visible == true).ToListAsync();
            return professions;
        }
    }
}
