using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunEklemeSistemi
{
    internal class UrunKategoriDb :DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Urun> Urunler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=UrunKategori;Trusted_Connection=True;TrustServerCertificate=true;");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urun>().HasOne(a=>a.Kategori).WithMany(a=>a.Urunler)
                .HasForeignKey(a=>a.KategoriId);
        }


        // "Server=.;Database=YZL3503Telefon;Trusted_Connection=True;TrustServerCertificate=true;"

    }
}
