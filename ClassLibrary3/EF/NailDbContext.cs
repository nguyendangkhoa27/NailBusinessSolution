using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NailProject.Data.Entities;
namespace NailProject.Data.EF
{
    internal class NailDbContext : DbContext
    {
        public NailDbContext(DbContextOptions contextOptions) :base(contextOptions) {
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Products> Products { set; get; }
    }
}
