using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class urunFotograf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fotograf",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fotograf",
                table: "Urunler");
        }
    }
}
