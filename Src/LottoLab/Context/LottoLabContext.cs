using LottoLab.Mapping;
using LottoLab.Models;
using Microsoft.EntityFrameworkCore;

namespace LottoLab.Context
{
    public class LottoLabContext : DbContext
    {
         public DbSet<LotoFacil> LotoFacilContext { get; set; }
         public DbSet<LotoFacilDelay> LotoFacilDelayContext { get; set; }
        public DbSet<LotoFacilRNA> LotoFacilRNAContext { get; set; }
        public DbSet<LotoFacilMostDown> LotoFacilMostDownContext { get; set; }
        public DbSet<LotoFacilRecurrent> LotoFacilRecurrentContext { get; set; }

        
          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../LottoLab"))
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LotoFacilMapping());
            modelBuilder.ApplyConfiguration(new LotoFacilDelayMapping());
            modelBuilder.ApplyConfiguration(new LotoFacilRNAMapping());
            modelBuilder.ApplyConfiguration(new LotoFacilMostDownMapping());
            modelBuilder.ApplyConfiguration(new LotoFacilRecurrentMapping());
         
        }
    }
}