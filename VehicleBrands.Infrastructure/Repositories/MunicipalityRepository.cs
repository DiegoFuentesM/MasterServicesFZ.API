using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class MunicipalityRepository : SqlRepositoryBase<Municipality>, IMunicipalityRepository
    {
        public MunicipalityRepository(SqlDbContext context) : base(context)
        {
        }

        public async Task<List<Municipality>> GetAllMunicipalityByDepartamentQuery(string departamentId)
        {
            var municipalities = await _context.Scr_Municipio!.Where(m => m.Departamento_Id == departamentId).OrderBy(m => m.Nombre).ToListAsync();
            return municipalities;
        }

    }
}
