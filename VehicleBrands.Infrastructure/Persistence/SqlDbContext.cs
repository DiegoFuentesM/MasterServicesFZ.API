using Microsoft.EntityFrameworkCore;

namespace MasterServicesFZ.Infrastructure.Persistence
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }


    }
}
