using Microsoft.EntityFrameworkCore;

namespace CryptoClearAPIBackend.DbModels
{
    public class CryptoClearDbContext : DbContext
    {
        public CryptoClearDbContext(DbContextOptions<CryptoClearDbContext> options) : base(options) { }

        public DbSet<Portfolio> Portfolio { get; set; }
    }
}
