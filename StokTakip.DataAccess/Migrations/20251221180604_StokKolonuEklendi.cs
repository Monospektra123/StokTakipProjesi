using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StokTakip.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class StokKolonuEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockQuantity",
                table: "Products",
                newName: "Stock");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Products",
                newName: "StockQuantity");
        }
    }
}
