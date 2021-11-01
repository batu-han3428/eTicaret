using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class UrunlerVeKategoriler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    createTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fiyat = table.Column<float>(type: "real", maxLength: 7, nullable: false),
                    IndirimliFiyat = table.Column<float>(type: "real", maxLength: 7, nullable: false),
                    IndirimYuzde = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    UrunAciklamaBaslik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UrunEkAciklama = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UrunAciklamaIcerik = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Stok = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DigerKategorileri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: true),
                    TeknikOzellikBaslik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TeknikOzellikIcerik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    createTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urunler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
