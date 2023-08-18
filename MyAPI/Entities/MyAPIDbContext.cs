using Microsoft.EntityFrameworkCore;

namespace MyAPI.Entities
{
    public class MyAPIDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrdersDetail> OrdersDetails { get; set; }

        public MyAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Accounts");
            modelBuilder.Entity<Store>().ToTable("Stores");
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Goods>().ToTable("Goods");
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<OrdersDetail>().ToTable("OrdersDetails").HasNoKey();
        }
    }
}
