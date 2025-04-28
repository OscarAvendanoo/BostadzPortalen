using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class JonaELess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "PropertiesForSale");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f72bb721-0bc3-42e6-bfa5-56259c5c797c", "7c5946c9-a638-4ec9-ae23-aa2ca6d56187" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa3c484f-cfed-4d10-b7c4-42a6fadbf690", "4d0f14d8-1aa8-4975-9338-f91c92d070dc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "PropertiesForSale",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "352918f2-384a-47bc-9e10-2f9577bbb9de", "ceb20ded-3c06-400f-8cb1-5078c192cadf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "77e39bbf-d731-4c65-bf0f-309cfbafffcb", "bb94b6ba-797b-4a92-a5ee-dac9cafeaddb" });
        }
    }
}
