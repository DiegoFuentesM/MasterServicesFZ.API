using Microsoft.EntityFrameworkCore;
using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Infrastructure.Persistence
{
    public class PostgresDbContext : DbContext
    {
        private const string FnzSchema = "fnz";
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentificactionType>()
                .ToTable("m_tipo_identificacion", FnzSchema);

            modelBuilder.Entity<VehicleBrand>()
                .ToTable("m_marca_vehiculo", FnzSchema);

            modelBuilder.Entity<VehicleType>()
                .ToTable("m_tipo_vehiculo", FnzSchema);

            modelBuilder.Entity<VehicleClassBrand>()
                .ToTable("m_marca_vehiculo_clase_vehiculo", FnzSchema);

            modelBuilder.Entity<Fee>()
                .ToTable("m_tasas", FnzSchema);
        }
        public DbSet<VehicleBrand>? m_marca_vehiculo { get; set; }
        public DbSet<IdentificactionType> m_tipo_identificacion { get; set; }
        public DbSet<VehicleType> m_tipo_vehiculo { get; set; }
        public DbSet<VehicleClassBrand> m_marca_vehiculo_clase_vehiculo { get; set; }
        public DbSet<Fee> m_tasas { get; set; }
    }
}
