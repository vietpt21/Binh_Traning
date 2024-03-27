using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyBook.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Viet", "Nuoc ngot", "jsjsjsjfnfee", 99.0, 90.0, 80.0, 85.0, "Cocacola" },
                    { 2, "Nam", "nuoc uong", "jsjsjsjfnfee", 40.0, 20.0, 35.0, 30.0, "pessi" },
                    { 3, "Viet", "jjseeejs", "eess", 99.0, 90.0, 80.0, 85.0, "Mi" },
                    { 4, "Viet", "fffff", "dddff", 80.0, 60.0, 10.0, 50.0, "Banh" },
                    { 5, "Hanh", "ssss", "ffff", 99.0, 90.0, 80.0, 85.0, "Ao" },
                    { 6, "Chan", "rrrs", "wwww", 99.0, 90.0, 80.0, 85.0, "Quan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
