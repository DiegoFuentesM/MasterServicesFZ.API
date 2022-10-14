using Microsoft.EntityFrameworkCore;
using VehicleBrands.Domain;

namespace VehicleBrands.Infrastructure.Persistence
{
    public class VehicleBrandsDbContext : DbContext
    {
        public VehicleBrandsDbContext(DbContextOptions<VehicleBrandsDbContext> options) : base(options)
        {
        }

        public DbSet<VehicleBrand>? m_marca_vehiculo { get; set; }
    }
}
