using DernekTakipOtomasyon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekTakipOtomasyon.DataAccessLayer.Context
{
    public class DernekTakipEntities : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Localde veritabanını oluşturduk
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=DernekTakip; Trusted_Connection=true;");

            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DernekTakip.mdf;Integrated Security=True;");
        }
        // Veritabanındaki alananları temsil eden DbSetler.
        public DbSet<Aidat> Aidat { get; set; }
        public DbSet<Aylar> Aylar { get; set; }
        public DbSet<Duyuru> Duyuru { get; set; }
        public DbSet<iller> iller { get; set; }
        public DbSet<Uye> Uye { get; set; }
        public DbSet<Yetkili> Yetkili { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Veritabanı oluştuğu anda aşağıdaki veriler Aylar tablosunda otomatik oluşturulacak.

            modelBuilder.Entity<Aylar>().HasData(
                new Aylar { ID = 1, AyAdi = "OCAK", Tutar = 100 },
                new Aylar { ID = 2, AyAdi = "ŞUBAT", Tutar = 200 },
                new Aylar { ID = 3, AyAdi = "MART", Tutar = 300 },
                new Aylar { ID = 4, AyAdi = "NİSAN", Tutar = 400 },
                new Aylar { ID = 5, AyAdi = "MAYIS", Tutar = 500 },
                new Aylar { ID = 6, AyAdi = "HAZİRAN", Tutar = 600 },
                new Aylar { ID = 7, AyAdi = "TEMMUZ", Tutar = 700 },
                new Aylar { ID = 8, AyAdi = "AĞUSTOS", Tutar = 800 },
                new Aylar { ID = 9, AyAdi = "EYLÜL", Tutar = 900 },
                new Aylar { ID = 10, AyAdi = "EKİM", Tutar = 1000 },
                new Aylar { ID = 11, AyAdi = "KASIM", Tutar = 1100 },
                new Aylar { ID = 12, AyAdi = "ARALIK", Tutar = 1200 }
             );

            // Yetkili tablosuna varsayılan bir admin adında yetkili ekleniyor ekleniyor.
            modelBuilder.Entity<Yetkili>().HasData(
                new Yetkili { ID=1, KullaniciAd="admin", Sifre="000"}
                );
        }
    }
}
