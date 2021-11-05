using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class markaFotograf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MarkaFotograf",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarkaFotograf",
                table: "Urunler");
        }
    }
}
