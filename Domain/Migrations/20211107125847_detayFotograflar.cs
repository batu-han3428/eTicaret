using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class detayFotograflar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "detayFotogaflar",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detayFotogaflar",
                table: "Urunler");
        }
    }
}
