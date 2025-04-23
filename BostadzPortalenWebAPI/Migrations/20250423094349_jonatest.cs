using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class jonatest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39be8be3-79fa-4017-b6fd-11e7751fa3a5", "7e59b371-2a9f-4e8e-9720-31ed4b74a926" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25242126-b4c4-40c4-8e9f-f2e8e759db71", "5b1ea84f-8c59-4f43-b44e-c8770ffb2a0d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
