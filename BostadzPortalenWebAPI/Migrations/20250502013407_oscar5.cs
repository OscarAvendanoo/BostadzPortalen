using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af2608a5-c960-4381-b0e7-f166230b15ca", "AQAAAAIAAYagAAAAEHZLyumRsULBZGtgycSBIoOXqh9scsiZDPKkVDSt2gZyVCiznGTn3SVRXT70UJ/UWw==", "d6bdd4f3-14e7-44d1-b3c2-ea1e4f726c01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26d2fc4d-023f-40bd-a249-f95789b30496", "AQAAAAIAAYagAAAAECz1PP5lfwKBv3t7nmX2eG1uXaR3/FAisV20gPqNmWhVL5uM3H/Zx4RWoPGFira2HA==", "dc275878-9e3b-49f1-9af8-a6b65bc83b29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ced42190-86c7-48cd-a650-75f3232ad02b", "AQAAAAIAAYagAAAAEKvTe/COZeXgScQTuxCpIc4aLdcKGX+C8AVsJ+Ov95c0JPSZ8Fivm/073aFi4JNPiw==", "27a21cf0-a762-4548-a5b4-1854a35e6f9a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83655e67-2282-41c9-92e7-e2d59ced07bf", "AQAAAAIAAYagAAAAED/nc/YIeBsZ+FMllbqvJ6m8JxD+od+sz8+EIdw+wX99QtA1J/ZQlFd1RegAk0socw==", "8a7ec8b4-ce1d-44f2-a746-188d1dd35b8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fb69600-dc36-482e-a75b-161bdbddbc76", "AQAAAAIAAYagAAAAEJtD/0F62JXITMz/miX6hpbQVMQcTRlAl1hI17dVGbI/GoAAhvrjo4ig3G0FLekOSw==", "e20d6f46-6d18-4758-980c-c4915d4ebb67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdaae8f7-5d53-454a-a20c-a555546fbcd1", "AQAAAAIAAYagAAAAEA87cZP9LOVXG7itHZ/gEma17WH9s6vw732CnyH+SJA4vyNI+g6Dt3rBbaMSvAcukw==", "af6ca6d1-5b20-467e-8ed7-14392adefa0b" });
        }
    }
}
