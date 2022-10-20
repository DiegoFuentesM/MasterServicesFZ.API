using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class VehicleClassRepository : RepositoryBase<VehicleClassBrand>, IVehicleClassRepository
    {
        public VehicleClassRepository(PostgresDbContext context) : base(context)
        {
        }

        public async Task<List<VehicleClassBrand>> GetClassByBrandId(string brandId)
        {
            return await _context.m_marca_vehiculo_clase_vehiculo.Where(c => c.marca_vehiculo_id == brandId).ToListAsync();
        }
    }
}
