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
            modelBuilder.Entity<Departament>()
                .ToTable("Scr_Departamento", DboSchema)
                .HasKey(d => d.CodigoLP);
        }

        public DbSet<Departament>? Scr_Departamento { get; set; }
    }
}
