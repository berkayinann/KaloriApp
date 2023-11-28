using KaloriApp.Domain.Entities.Recipes;
using KaloriApp.Domain.Entities.Reports;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriApp.DAL.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<Tarif> Tarifler { get; set; }
        public DbSet<HaftalikRapor> HaftalikRaporlar { get; set; }
        public DbSet<Rapor> Raporlar { get; set; }
    }
}
