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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            #region GlobalQuery

            modelBuilder.Entity<Kategoriler>()
                .HasQueryFilter(p => p.isDeleted == false);

            modelBuilder.Entity<Urunler>()
                .HasQueryFilter(p => p.isDeleted == false);

            #endregion

            #region Bire çok ilişki
            modelBuilder.Entity<Urunler>()
                .HasOne<Kategoriler>(s => s.Kategori)
                .WithMany(g => g.urunAdi);

            modelBuilder.Entity<detayFotograflar>()
                .HasOne<Urunler>(s => s.urunler)
                .WithMany(g => g.detayFotograflar);
            #endregion


            modelBuilder.Entity<Kategoriler>().Property(e => e.Aciklama).HasMaxLength(400).IsRequired();
            modelBuilder.Entity<Kategoriler>().Property(e => e.Ad).HasMaxLength(50).IsRequired();


            modelBuilder.Entity<Urunler>().Property(e => e.Ad).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.DigerKategorileri).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.Fiyat).HasMaxLength(7).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.IndirimliFiyat).HasMaxLength(7);
            modelBuilder.Entity<Urunler>().Property(e => e.IndirimYuzde).HasMaxLength(3);
            modelBuilder.Entity<Urunler>().Property(e => e.Marka).HasMaxLength(15).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.Stok).HasMaxLength(6).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.TeknikOzellikBaslik).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.TeknikOzellikIcerik).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.UrunAciklamaBaslik).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Urunler>().Property(e => e.UrunAciklamaIcerik).HasMaxLength(500).IsRequired();
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
