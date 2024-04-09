using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyBook.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class AddDataCompanytables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Hai Phong", "LG", "03782782732", "DKFANFF", "adajdjF", "Trang due" },
                    { 2, "Hai Phong", "SamSung", "035932782732", "DKJHJNFF", "adajdjF", "Trang due" },
                    { 3, "Hai Phong", "Hoa Mai", "0378582732", "DKFAKJHNFF", "adajffaddjF", "Vinh bao" },
                    { 4, "Hai Phong", "May", "03984782732", "DKFAUHNNFF", "adadqqjdjF", "Vnh bao" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
