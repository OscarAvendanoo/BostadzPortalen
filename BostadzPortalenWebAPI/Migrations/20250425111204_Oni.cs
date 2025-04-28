using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Oni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
