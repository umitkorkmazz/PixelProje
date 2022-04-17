using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixelProje.Dal.Migrations
{
    public partial class uc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceAmount",
                table: "Invoice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AboneSituation",
                table: "Abone",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceAmount",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "AboneSituation",
                table: "Abone");
        }
    }
}
