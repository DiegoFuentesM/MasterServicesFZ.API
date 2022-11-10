using MasterServicesFZ.Domain;
using Microsoft.EntityFrameworkCore;

namespace MasterServicesFZ.Infrastructure.Persistence
{
    public class CreditProductsDbContext : DbContext
    {
        private const string DboSchema = "CRE";

        public CreditProductsDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountType>()
                .ToTable("TiposCuenta", DboSchema)
                .HasKey(m => m.TipoCuentaID);
        }
        public DbSet<AccountType> TiposCuenta { get; set; }
    }
}
