using Microsoft.EntityFrameworkCore;
using eshop.DataAccess.Entity;

namespace eshop.DataAccess.EshopContext
{
    public class EshopDbContext : DbContext
    {
        public EshopDbContext(DbContextOptions<EshopDbContext> opt) : base(opt)
        {

        }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProductEntiry> Products { get; set; }
        public DbSet<PictureEntity> Pictures { get; set; }
        public DbSet<UnitTypeEntity> UnitTypes { get; set; }
        public DbSet<CustomerEntry> Customers { get; set; }
        public DbSet<CustomerRoleEntry> CustomerRoles { get; set; }
        public DbSet<CustomerPasswordEntry> CustomerPasswords { get; set; }
        public DbSet<PaymentMethodEntry> PaymentMethods { get; set; }
        public DbSet<OrderStatusEntry> OrderStatuses { get; set; }
        public DbSet<OrderEntry> Orders { get; set; }
        public DbSet<OrderItemEntry> OrderItems { get; set; }
        public DbSet<QueuedEmailEntry> QueuedEmails { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    IConfigurationRoot configuration = new ConfigurationBuilder()
        //   .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //   .AddJsonFile("appsettings.json")
        //   .Build();

        //    optionsBuilder.UseSqlServer((configuration.GetConnectionString("OnlineShoppingConnection")));
        //}


    }
}
