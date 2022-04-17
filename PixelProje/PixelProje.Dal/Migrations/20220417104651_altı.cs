using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixelProje.Dal.Migrations
{
    public partial class altı : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abone_Invoice_InvoiceId",
                table: "Abone");

            migrationBuilder.DropIndex(
                name: "IX_Abone_InvoiceId",
                table: "Abone");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Abone");

            migrationBuilder.AddColumn<int>(
                name: "AboneId",
                table: "Invoice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InvoicesInvoiceId",
                table: "Invoice",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_AboneId",
                table: "Invoice",
                column: "AboneId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_InvoicesInvoiceId",
                table: "Invoice",
                column: "InvoicesInvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Abone_AboneId",
                table: "Invoice",
                column: "AboneId",
                principalTable: "Abone",
                principalColumn: "AboneId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Invoice_InvoicesInvoiceId",
                table: "Invoice",
                column: "InvoicesInvoiceId",
                principalTable: "Invoice",
                principalColumn: "InvoiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Abone_AboneId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Invoice_InvoicesInvoiceId",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_AboneId",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_InvoicesInvoiceId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "AboneId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "InvoicesInvoiceId",
                table: "Invoice");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Abone",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Abone_InvoiceId",
                table: "Abone",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abone_Invoice_InvoiceId",
                table: "Abone",
                column: "InvoiceId",
                principalTable: "Invoice",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
