using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebTest.Models.BD
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI;Database=BDPriceList;User ID=MSI\rusae;password=123;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        
        public DbSet<Pricelist> Pricelists { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<ColumnElementPar> ColumnElements { get; set; }

    }
}
