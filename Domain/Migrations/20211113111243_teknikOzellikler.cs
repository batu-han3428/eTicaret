using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class teknikOzellikler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeknikOzellikler_TeknikOzellikDegerleri_teknikOzellikDegerleriid",
                table: "TeknikOzellikler");

            migrationBuilder.DropForeignKey(
                name: "FK_TeknikOzellikler_teknikOzelliklerAltBaslik_TeknikOzelliklerAltBaslikid",
                table: "TeknikOzellikler");

            migrationBuilder.DropTable(
                name: "TeknikOzellikDegerleri");

            migrationBuilder.DropTable(
                name: "teknikOzelliklerAltBaslik");

            migrationBuilder.DropIndex(
                name: "IX_TeknikOzellikler_teknikOzellikDegerleriid",
                table: "TeknikOzellikler");

            migrationBuilder.DropIndex(
                name: "IX_TeknikOzellikler_TeknikOzelliklerAltBaslikid",
                table: "TeknikOzellikler");

            migrationBuilder.DropColumn(
                name: "TeknikOzelliklerAltBaslikid",
                table: "TeknikOzellikler");

            migrationBuilder.DropColumn(
                name: "teknikOzellikDegerleriid",
                table: "TeknikOzellikler");

            migrationBuilder.AddColumn<string>(
                name: "TeknikOzelliklerAltBaslik",
                table: "TeknikOzellikler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "teknikOzellikDegerleri",
                table: "TeknikOzellikler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeknikOzelliklerAltBaslik",
                table: "TeknikOzellikler");

            migrationBuilder.DropColumn(
                name: "teknikOzellikDegerleri",
                table: "TeknikOzellikler");

            migrationBuilder.AddColumn<int>(
                name: "TeknikOzelliklerAltBaslikid",
                table: "TeknikOzellikler",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "teknikOzellikDegerleriid",
                table: "TeknikOzellikler",
                type: "int",
                nullable: true);

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
                name: "teknikOzelliklerAltBaslik",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    altBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teknikOzelliklerAltBaslik", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeknikOzellikler_teknikOzellikDegerleriid",
                table: "TeknikOzellikler",
                column: "teknikOzellikDegerleriid");

            migrationBuilder.CreateIndex(
                name: "IX_TeknikOzellikler_TeknikOzelliklerAltBaslikid",
                table: "TeknikOzellikler",
                column: "TeknikOzelliklerAltBaslikid");

            migrationBuilder.AddForeignKey(
                name: "FK_TeknikOzellikler_TeknikOzellikDegerleri_teknikOzellikDegerleriid",
                table: "TeknikOzellikler",
                column: "teknikOzellikDegerleriid",
                principalTable: "TeknikOzellikDegerleri",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeknikOzellikler_teknikOzelliklerAltBaslik_TeknikOzelliklerAltBaslikid",
                table: "TeknikOzellikler",
                column: "TeknikOzelliklerAltBaslikid",
                principalTable: "teknikOzelliklerAltBaslik",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
