using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class fuckyou : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "PropertiesForSale",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "60b83dee-6665-409d-9633-2ac8281f894a", "26516545-1148-43f9-996d-35b417d129b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0dd2eca3-72a0-4f41-a669-8e79ea3ca2bf", "b978c799-a883-48c4-b991-f7089ddcb93c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "PropertiesForSale");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7cda4b01-04b8-4573-92a2-7a9e69a05b6f", "95a18b8a-9dc6-458e-866c-fe502c526871" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6cccc997-e86a-4a6a-8957-c6ab98b46744", "4733388b-4fd5-4771-8d34-89b7a9bfbb54" });
        }
    }
}
