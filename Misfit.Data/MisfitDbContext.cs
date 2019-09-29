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
                .AddJsonFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json"))
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MisfitConnection"));
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserResult> UserResults { get; set; }
    }
}
