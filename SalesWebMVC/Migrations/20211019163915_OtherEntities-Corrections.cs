using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMVC.Migrations
{
    public partial class OtherEntitiesCorrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleRecord_Seller_SellerId",
                table: "SaleRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleRecord",
                table: "SaleRecord");

            migrationBuilder.RenameTable(
                name: "SaleRecord",
                newName: "SalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SaleRecord_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "SaleRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SaleRecord",
                newName: "IX_SaleRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleRecord",
                table: "SaleRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleRecord_Seller_SellerId",
                table: "SaleRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
