using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    internal class VehicleTypeRepository : RepositoryBase<VehicleType>, IVehicleTypeRepository
    {
        public VehicleTypeRepository(PostgresDbContext context) : base(context)
        {
        }

        public async Task<int> GetClassBrandId(string classId, string brandId)
        {
            return await _context.m_marca_vehiculo_clase_vehiculo
                .Where(x => x.clase_vehiculo_id == classId && x.marca_vehiculo_id == brandId)
                .Select(x => x.id).FirstOrDefaultAsync();
        }
        public async Task<List<VehicleType>> GetAllByClassBrandId(int classBrandId)
        {
            return await _context.m_tipo_vehiculo
                 .Where(x => x.marca_clase_vehiculo_clase_id == classBrandId).ToListAsync();
        }
    }
}
