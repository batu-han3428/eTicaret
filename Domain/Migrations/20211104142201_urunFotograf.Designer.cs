﻿// <auto-generated />
using System;
using Domain.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20211104142201_urunFotograf")]
    partial class urunFotograf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Concrete.Kategoriler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("createTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("updateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("Domain.Concrete.Urunler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DeletedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DigerKategorileri")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Fiyat")
                        .HasMaxLength(7)
                        .HasColumnType("real");

                    b.Property<string>("Fotograf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IndirimYuzde")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<float>("IndirimliFiyat")
                        .HasMaxLength(7)
                        .HasColumnType("real");

                    b.Property<int?>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Stok")
                        .HasMaxLength(6)
                        .HasColumnType("int");

                    b.Property<string>("TeknikOzellikBaslik")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TeknikOzellikIcerik")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UrunAciklamaBaslik")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UrunAciklamaIcerik")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("UrunEkAciklama")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("createTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("updateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("Domain.Concrete.Urunler", b =>
                {
                    b.HasOne("Domain.Concrete.Kategoriler", "Kategori")
                        .WithMany("urunAdi")
                        .HasForeignKey("KategoriId");

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("Domain.Concrete.Kategoriler", b =>
                {
                    b.Navigation("urunAdi");
                });
#pragma warning restore 612, 618
        }
    }
}
