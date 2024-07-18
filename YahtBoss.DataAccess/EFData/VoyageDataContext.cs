using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtBoss.DataAccess.EFData
{
    public class VoyageDataContext : DbContext
    {
        public DbSet<Voyage> Voyages { get; set; }
        public DbSet<VoyageEvent> VoyageEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Port=5433;Host=localhost;Database=yahtboss-db-1;Username=postgres;Password=postgres;Persist Security Info=True");
        }
    }
}
