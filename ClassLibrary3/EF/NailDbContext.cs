using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NailProject.Data.Configurations;
using NailProject.Data.Entities;
namespace NailProject.Data.EF
{
    public class NailDbContext : DbContext
    {
        public NailDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductsConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrdersConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());

            /* base.OnModelCreating(modelBuilder);*/
        }
        public DbSet<Products> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<AppConfig> Appconfig { set; get; }
        public DbSet<OrderDetail> OrderDetail { set; get; }
        public DbSet<Orders> Orders { set; get; }
        public DbSet<ProductInCategory> ProductInCategories { set; get; }

    }
}
