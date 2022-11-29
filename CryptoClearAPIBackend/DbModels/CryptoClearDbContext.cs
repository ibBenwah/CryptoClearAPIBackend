using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Transactions;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace CryptoClearAPIBackend.DbModels
{
    public class CryptoClearDbContext : DbContext
    {
        public CryptoClearDbContext(DbContextOptions<CryptoClearDbContext> options) : base(options) { }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<User> User { get; set; }
    }
}
