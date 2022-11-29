using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace CryptoClearAPIBackend.DbModels
{
    public class CryptoClearDbContext : DbContext
    {
        public CryptoClearDbContext(DbContextOptions<CryptoClearDbContext> options) : base(options) { }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
