using Microsoft.EntityFrameworkCore;

namespace BilakProjectBackend.Models
{
    public class BilakDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Ebill> Ebills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionString = "Data Source=DESKTOP-I46N7EU\\SQLEXPRESS;Initial Catalog=BilakDb;Integrated Security=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
