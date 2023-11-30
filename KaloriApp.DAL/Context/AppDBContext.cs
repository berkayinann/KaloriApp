
using KaloriApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace KaloriApp.DAL.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<Tarif> Tarifler { get; set; }
        public DbSet<HaftalikRapor> HaftalikRaporlar { get; set; }
        public DbSet<Rapor> Raporlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Tarık ConString
            optionsBuilder.UseSqlServer("server=TARKOVSKI\\MSSQLSERVERBOOST;database=KaloriApp;trusted_connection=true;");
            // Berkay ConString
           
            // Gökçe ConString
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarif>().HasData(
       
   );

            base.OnModelCreating(modelBuilder);
        }
    }
}
