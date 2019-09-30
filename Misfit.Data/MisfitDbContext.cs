using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Misfit.Model;

namespace Misfit.Data
{
    public class MisfitDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MisfitConnection"));
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserResult> UserResults { get; set; }
    }
}
