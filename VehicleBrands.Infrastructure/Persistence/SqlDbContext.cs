using MasterServicesFZ.Domain;
using Microsoft.EntityFrameworkCore;

namespace MasterServicesFZ.Infrastructure.Persistence
{
    public class SqlDbContext : DbContext
    {
        private const string DboSchema = "dbo";

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .ToTable("Scr_Departamento", DboSchema)
                .HasKey(d => d.CodigoLP);

            modelBuilder.Entity<Municipality>()
                .ToTable("Scr_Municipio", DboSchema)
                .HasKey(m => m.CodigoLP);

            modelBuilder.Entity<Occupation>()
                .ToTable("Scr_Ocupacion", DboSchema)
                .HasKey(m => m.CodigoLP);

            modelBuilder.Entity<ContractType>()
                .ToTable("Scr_TipoContrato", DboSchema)
                .HasKey(m => m.CodigoLP);
        }

        public DbSet<Department>? Scr_Departamento { get; set; }
        public DbSet<Municipality>? Scr_Municipio { get; set; }
        public DbSet<Occupation>? Scr_Ocupacion { get; set; }
        public DbSet<ContractType>? Scr_TipoContrato { get; set; }
    }
}
