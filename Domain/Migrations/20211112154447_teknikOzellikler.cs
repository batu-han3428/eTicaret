using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class teknikOzellikler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeknikOzellikBaslik",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "TeknikOzellikIcerik",
                table: "Urunler");

            migrationBuilder.CreateTable(
                name: "teknikOzellikDegerleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teknikOzellikDegeri = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teknikOzellikDegerleri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TeknikOzellikler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teknikOzellikBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teknikOzellikDegerleriid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeknikOzellikler", x => x.id);
                    table.ForeignKey(
                        name: "FK_TeknikOzellikler_teknikOzellikDegerleri_teknikOzellikDegerleriid",
                        column: x => x.teknikOzellikDegerleriid,
                        principalTable: "teknikOzellikDegerleri",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "urunlerTeknikOzellikler",
                columns: table => new
                {
                    urunlerId = table.Column<int>(type: "int", nullable: false),
                    teknikOzelliklerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunlerTeknikOzellikler", x => new { x.urunlerId, x.teknikOzelliklerId });
                    table.ForeignKey(
                        name: "FK_urunlerTeknikOzellikler_TeknikOzellikler_teknikOzelliklerId",
                        column: x => x.teknikOzelliklerId,
                        principalTable: "TeknikOzellikler",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_urunlerTeknikOzellikler_Urunler_urunlerId",
                        column: x => x.urunlerId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeknikOzellikler_teknikOzellikDegerleriid",
                table: "TeknikOzellikler",
                column: "teknikOzellikDegerleriid");

            migrationBuilder.CreateIndex(
                name: "IX_urunlerTeknikOzellikler_teknikOzelliklerId",
                table: "urunlerTeknikOzellikler",
                column: "teknikOzelliklerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "urunlerTeknikOzellikler");

            migrationBuilder.DropTable(
                name: "TeknikOzellikler");

            migrationBuilder.DropTable(
                name: "teknikOzellikDegerleri");

            migrationBuilder.AddColumn<string>(
                name: "TeknikOzellikBaslik",
                table: "Urunler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeknikOzellikIcerik",
                table: "Urunler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
