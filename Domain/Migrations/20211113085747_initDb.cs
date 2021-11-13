using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class initDb : Migration
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
                name: "TeknikOzellikDegerleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teknikOzellikDegeri = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeknikOzellikDegerleri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TeknikOzelliklerAnaBaslik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anaBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeknikOzelliklerAnaBaslik", x => x.Id);
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
                    UrunAciklamaIcerik = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Stok = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DigerKategorileri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: true),
                    createTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fotograf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarkaFotograf = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "TeknikOzellikler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teknikOzellikBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teknikOzellikDegerleriid = table.Column<int>(type: "int", nullable: true),
                    TeknikOzelliklerAnaBaslikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeknikOzellikler", x => x.id);
                    table.ForeignKey(
                        name: "FK_TeknikOzellikler_TeknikOzellikDegerleri_teknikOzellikDegerleriid",
                        column: x => x.teknikOzellikDegerleriid,
                        principalTable: "TeknikOzellikDegerleri",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeknikOzellikler_TeknikOzelliklerAnaBaslik_TeknikOzelliklerAnaBaslikId",
                        column: x => x.TeknikOzelliklerAnaBaslikId,
                        principalTable: "TeknikOzelliklerAnaBaslik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetayFotograflar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detayFotograf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urunlerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetayFotograflar", x => x.id);
                    table.ForeignKey(
                        name: "FK_DetayFotograflar_Urunler_urunlerId",
                        column: x => x.urunlerId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "urunlerTeknikOzellikler",
                columns: table => new
                {
                    urunlerId = table.Column<int>(type: "int", nullable: false),
                    teknikOzelliklerAnaBaslikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunlerTeknikOzellikler", x => new { x.urunlerId, x.teknikOzelliklerAnaBaslikId });
                    table.ForeignKey(
                        name: "FK_urunlerTeknikOzellikler_TeknikOzelliklerAnaBaslik_teknikOzelliklerAnaBaslikId",
                        column: x => x.teknikOzelliklerAnaBaslikId,
                        principalTable: "TeknikOzelliklerAnaBaslik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_urunlerTeknikOzellikler_Urunler_urunlerId",
                        column: x => x.urunlerId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetayFotograflar_urunlerId",
                table: "DetayFotograflar",
                column: "urunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeknikOzellikler_teknikOzellikDegerleriid",
                table: "TeknikOzellikler",
                column: "teknikOzellikDegerleriid");

            migrationBuilder.CreateIndex(
                name: "IX_TeknikOzellikler_TeknikOzelliklerAnaBaslikId",
                table: "TeknikOzellikler",
                column: "TeknikOzelliklerAnaBaslikId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_urunlerTeknikOzellikler_teknikOzelliklerAnaBaslikId",
                table: "urunlerTeknikOzellikler",
                column: "teknikOzelliklerAnaBaslikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetayFotograflar");

            migrationBuilder.DropTable(
                name: "TeknikOzellikler");

            migrationBuilder.DropTable(
                name: "urunlerTeknikOzellikler");

            migrationBuilder.DropTable(
                name: "TeknikOzellikDegerleri");

            migrationBuilder.DropTable(
                name: "TeknikOzelliklerAnaBaslik");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
