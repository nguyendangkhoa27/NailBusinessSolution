using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailProject.Data.EF
{
    public class NailDbContextFactory : IDesignTimeDbContextFactory<NailDbContext>
    {
        NailDbContext IDesignTimeDbContextFactory<NailDbContext>.CreateDbContext(string[] args)
        { 
            string connectionString = "Host=127.0.0.1;Database=Nail;Username=postgres;Password=123456";
            var optionsBuilder = new DbContextOptionsBuilder<NailDbContext>();
            optionsBuilder.UseNpgsql(connectionString);
            return new NailDbContext(optionsBuilder.Options);
        }
    }
}
