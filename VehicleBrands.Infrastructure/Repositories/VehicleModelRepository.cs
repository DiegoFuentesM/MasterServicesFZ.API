using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class VehicleModelRepository : RepositoryBase<GenericResponseVM>, IVehicleModelRepository
    {
        public VehicleModelRepository(PostgresDbContext context) : base(context)
        {
        }

        public async Task<List<GenericResponseVM>> GetAllModelsByVehicleType(int vehicleTypeID)
        {
            var models = await _context.m_precio_fasecolda_nuevo
                .Where(x => x.precio > 0 && x.tipovehiculo_id == vehicleTypeID && x.modelovehiculo_id != 0 && x.estado)
                .Select(x => new GenericResponseVM { Id = x.modelovehiculo_id.ToString(), Value = x.modelovehiculo_id.ToString() })
                .Concat(_context.m_precio_fasecolda_nuevo.Where(x => x.precio > 0 && x.tipovehiculo_id == vehicleTypeID && x.modelobienvehiculo_id != 0 && x.estado)
                .Select(x => new GenericResponseVM { Id = x.modelobienvehiculo_id.ToString(), Value = x.modelobienvehiculo_id.ToString() })).Distinct().ToListAsync();

            return models;
        }
    }
}
