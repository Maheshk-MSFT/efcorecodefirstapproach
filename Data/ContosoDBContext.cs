using efcorecodefirstapproach.Models;
using Microsoft.EntityFrameworkCore;

namespace efcorecodefirstapproach
{
    class ContosoDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductOrder> ProductOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=webapidemodb;");
        }
    }
}
