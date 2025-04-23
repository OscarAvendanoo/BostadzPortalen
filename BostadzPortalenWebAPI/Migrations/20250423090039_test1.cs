using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d30a5067-e1ba-4f66-80fb-888dd2a5c4e9", "0e52b6a0-0d43-4de2-a68a-f1f06186d4cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "026b45fb-dbc1-43d4-96d3-650cbcbf7788", "ac1b6a83-8543-4031-af32-2ccae1585da1" });
        }
    }
}
