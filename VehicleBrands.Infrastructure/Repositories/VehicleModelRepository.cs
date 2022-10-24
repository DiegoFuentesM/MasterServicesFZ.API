using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class VehicleModelRepository : RepositoryBase<VehicleModel>, IVehicleModelRepository
    {
        public VehicleModelRepository(PostgresDbContext context) : base(context)
        {
        }

        public async Task<List<int>> GetAllModelsByVehicleType(int vehicleTypeID)
        {
            //var prueba = await _context.m_precio_fasecolda_nuevo.ToListAsync();

            var models = await _context.m_precio_fasecolda_nuevo
                .Where(x => x.precio >= 0 && x.estado && x.tipovehiculo_id == vehicleTypeID && x.modelobienvehiculo_id != 0)
                .Select(x => x.modelovehiculo_id)
                .Concat(_context.m_precio_fasecolda_nuevo
                .Where(x => x.precio >= 0 && x.estado && x.tipovehiculo_id == vehicleTypeID && x.modelobienvehiculo_id != 0)
                .Select(x => x.modelobienvehiculo_id)).Distinct().ToListAsync();

            return models;
        }
    }
}
