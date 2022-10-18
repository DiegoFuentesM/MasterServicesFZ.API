using Microsoft.EntityFrameworkCore;
using VehicleBrands.Domain;

namespace VehicleBrands.Infrastructure.Persistence
{
    public class VehicleBrandsDbContext : DbContext
    {
        private const string FnzSchema = "fnz";
        public VehicleBrandsDbContext(DbContextOptions<VehicleBrandsDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleBrand>()
                .ToTable("m_marca_vehiculo", FnzSchema);
        }
        public DbSet<VehicleBrand>? m_marca_vehiculo { get; set; }
    }
}
