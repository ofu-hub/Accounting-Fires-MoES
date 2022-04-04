using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Models;
using Microsoft.EntityFrameworkCore;

namespace WpfApp.Data
{
    internal class DataBase : DbContext
    {
        public DbSet<FileReport> FileRepots { get; set; }
        public DbSet<GeneralInformation> GeneralInformations { get; set; }

        public DataBase()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=moes_db;Username=postgres;Password=12345");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
