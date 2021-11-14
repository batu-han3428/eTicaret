using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class altKategoriİslemleri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DigerKategorileri",
                table: "Urunler");

            migrationBuilder.CreateTable(
                name: "AltKategoriler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    altKategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltKategoriler", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kategorilerAltKategoriler",
                columns: table => new
                {
                    kategorilerId = table.Column<int>(type: "int", nullable: false),
                    AltKategorilerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategorilerAltKategoriler", x => new { x.kategorilerId, x.AltKategorilerId });
                    table.ForeignKey(
                        name: "FK_kategorilerAltKategoriler_AltKategoriler_AltKategorilerId",
                        column: x => x.AltKategorilerId,
                        principalTable: "AltKategoriler",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kategorilerAltKategoriler_Kategoriler_kategorilerId",
                        column: x => x.kategorilerId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "urunlerAltKategoriler",
                columns: table => new
                {
                    urunlerId = table.Column<int>(type: "int", nullable: false),
                    AltKategorilerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunlerAltKategoriler", x => new { x.urunlerId, x.AltKategorilerId });
                    table.ForeignKey(
                        name: "FK_urunlerAltKategoriler_AltKategoriler_AltKategorilerId",
                        column: x => x.AltKategorilerId,
                        principalTable: "AltKategoriler",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_urunlerAltKategoriler_Urunler_urunlerId",
                        column: x => x.urunlerId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kategorilerAltKategoriler_AltKategorilerId",
                table: "kategorilerAltKategoriler",
                column: "AltKategorilerId");

            migrationBuilder.CreateIndex(
                name: "IX_urunlerAltKategoriler_AltKategorilerId",
                table: "urunlerAltKategoriler",
                column: "AltKategorilerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kategorilerAltKategoriler");

            migrationBuilder.DropTable(
                name: "urunlerAltKategoriler");

            migrationBuilder.DropTable(
                name: "AltKategoriler");

            migrationBuilder.AddColumn<string>(
                name: "DigerKategorileri",
                table: "Urunler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
