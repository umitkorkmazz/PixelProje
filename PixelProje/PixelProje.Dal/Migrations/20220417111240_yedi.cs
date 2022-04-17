using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixelProje.Dal.Migrations
{
    public partial class yedi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Balance",
                table: "Abone",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Abone");
        }
    }
}
