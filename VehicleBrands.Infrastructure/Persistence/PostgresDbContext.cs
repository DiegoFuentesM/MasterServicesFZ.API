using Microsoft.EntityFrameworkCore;
using Core.Domain;

namespace Infrastructure.Persistence
{
    public class PostgresDbContext : DbContext
    {
        private const string FnzSchema = "fnz";
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options)
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
