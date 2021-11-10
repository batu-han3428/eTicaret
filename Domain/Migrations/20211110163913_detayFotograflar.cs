using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class detayFotograflar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detayFotogaflar",
                table: "Urunler");

            migrationBuilder.CreateTable(
                name: "detayFotograflar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detayFotograf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urunlerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detayFotograflar", x => x.id);
                    table.ForeignKey(
                        name: "FK_detayFotograflar_Urunler_urunlerId",
                        column: x => x.urunlerId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detayFotograflar_urunlerId",
                table: "detayFotograflar",
                column: "urunlerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detayFotograflar");

            migrationBuilder.AddColumn<string>(
                name: "detayFotogaflar",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
