using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBook.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNameTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OderDetails_OrderHeaders_OrderId",
                table: "OderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OderDetails_products_ProductId",
                table: "OderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OderDetails",
                table: "OderDetails");

            migrationBuilder.RenameTable(
                name: "OderDetails",
                newName: "OrderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_OderDetails_ProductId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OderDetails_OrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderHeaders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "OrderHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderHeaders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_products_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OderDetails",
                newName: "IX_OderDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OderDetails",
                newName: "IX_OderDetails_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OderDetails",
                table: "OderDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OderDetails_OrderHeaders_OrderId",
                table: "OderDetails",
                column: "OrderId",
                principalTable: "OrderHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OderDetails_products_ProductId",
                table: "OderDetails",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
