using Domain.Concrete;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contexts
{
    public class SqlDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MsSqlLocalDb;Database=ETicaretReact;Trusted_Connection=true;");
        }

        public DbSet<Kategoriler> Kategoriler { get; set; }
        public DbSet<Urunler> Urunler { get; set; }
        public DbSet<detayFotograflar> DetayFotograflar { get; set; }
        public DbSet<TeknikOzellikler> TeknikOzellikler { get; set; }
        public DbSet<TeknikOzelliklerAnaBaslik> TeknikOzelliklerAnaBaslik { get; set; }
        public DbSet<urunlerTeknikOzellikler> urunlerTeknikOzellikler { get; set; }
        public DbSet<AltKategoriler> AltKategoriler { get; set; }
        public DbSet<kategorilerAltKategoriler> kategorilerAltKategoriler { get; set; }
        public DbSet<urunlerAltKategoriler> urunlerAltKategoriler { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            #region GlobalQuery

            modelBuilder.Entity<Kategoriler>()
                .HasQueryFilter(p => p.isDeleted == false);

            modelBuilder.Entity<Urunler>()
                .HasQueryFilter(p => p.isDeleted == false);

            #endregion

            #region Bire çok ilişkiler
            modelBuilder.Entity<Urunler>()
                .HasOne<Kategoriler>(s => s.Kategori)
                .WithMany(g => g.urunAdi);

            modelBuilder.Entity<detayFotograflar>()
                .HasOne<Urunler>(s => s.urunler)
                .WithMany(g => g.detayFotograflar);         

            modelBuilder.Entity<TeknikOzellikler>()
                .HasOne<TeknikOzelliklerAnaBaslik>(s => s.TeknikOzelliklerAnaBaslik)
                .WithMany(g => g.TeknikOzellikler);
            #endregion

            #region Çoka çok ilişkiler
            modelBuilder.Entity<urunlerTeknikOzellikler>()
               .HasKey(hk => new { hk.urunlerId, hk.teknikOzelliklerAnaBaslikId });

            modelBuilder.Entity<urunlerTeknikOzellikler>()
            .HasOne(hk => hk.TeknikOzelliklerAnaBaslik)
            .WithMany(h => h.urunlerTeknikOzellikler)
            .HasForeignKey(hk => hk.teknikOzelliklerAnaBaslikId);

            modelBuilder.Entity<urunlerTeknikOzellikler>()
            .HasOne(hk => hk.urunler)
            .WithMany(k => k.urunlerTeknikOzellikler)
            .HasForeignKey(hk => hk.urunlerId);



            modelBuilder.Entity<kategorilerAltKategoriler>()
               .HasKey(hk => new { hk.kategorilerId, hk.AltKategorilerId });

            modelBuilder.Entity<kategorilerAltKategoriler>()
            .HasOne(hk => hk.AltKategoriler)
            .WithMany(h => h.kategorilerAltKategoriler)
            .HasForeignKey(hk => hk.AltKategorilerId);

            modelBuilder.Entity<kategorilerAltKategoriler>()
            .HasOne(hk => hk.Kategoriler)
            .WithMany(k => k.kategorilerAltKategoriler)
            .HasForeignKey(hk => hk.kategorilerId);



            modelBuilder.Entity<urunlerAltKategoriler>()
               .HasKey(hk => new { hk.urunlerId, hk.AltKategorilerId });

            modelBuilder.Entity<urunlerAltKategoriler>()
            .HasOne(hk => hk.AltKategoriler)
            .WithMany(h => h.urunlerAltKategoriler)
            .HasForeignKey(hk => hk.AltKategorilerId);

            modelBuilder.Entity<urunlerAltKategoriler>()
            .HasOne(hk => hk.Urunler)
            .WithMany(k => k.urunlerAltKategoriler)
            .HasForeignKey(hk => hk.urunlerId);
            #endregion


            modelBuilder.Entity<Kategoriler>().Property(e => e.Aciklama).HasMaxLength(400).IsRequired();
            modelBuilder.Entity<Kategoriler>().Property(e => e.Ad).HasMaxLength(50).IsRequired();


            modelBuilder.Entity<Urunler>().Property(e => e.Ad).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.Fiyat).HasMaxLength(7).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.IndirimliFiyat).HasMaxLength(7);
            modelBuilder.Entity<Urunler>().Property(e => e.IndirimYuzde).HasMaxLength(3);
            modelBuilder.Entity<Urunler>().Property(e => e.Marka).HasMaxLength(15).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.Stok).HasMaxLength(6).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.UrunAciklamaBaslik).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.UrunAciklamaIcerik).HasMaxLength(1000).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.UrunEkAciklama).HasMaxLength(50).IsRequired();
        }

        public override int SaveChanges()
        {
            this.ChangeTracker.DetectChanges();

            foreach (var entry in ChangeTracker.Entries<IAuditEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    case EntityState.Modified:
                        entry.Entity.updateTime = DateTime.Now;
                        break;
                    case EntityState.Added:
                        entry.Entity.createTime = DateTime.Now;
                        break;
                    default:
                        break;
                }
            }

            foreach (var entry in ChangeTracker.Entries<ISoftDelete>())
            {
                switch (entry.State)
                {
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        entry.Entity.DeletedTime = DateTime.Now;
                        entry.Entity.isDeleted = true;
                        break;
                    case EntityState.Modified:
                        break;
                    case EntityState.Added:
                        break;
                    default:
                        break;
                }
            }

            return base.SaveChanges();
        }
    }
}
