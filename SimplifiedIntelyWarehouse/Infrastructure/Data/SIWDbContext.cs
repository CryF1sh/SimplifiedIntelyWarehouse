using Microsoft.EntityFrameworkCore;

namespace SimplifiedIntelyWarehouse.Infrastructure.Data
{
    public class SIWDbContext : DbContext
    {
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Stock> Stocks { get; set; }
        //public DbSet<Transaction> Transactions { get; set; }

        public SIWDbContext(DbContextOptions<SIWDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка сущностей
        }
    }
}
