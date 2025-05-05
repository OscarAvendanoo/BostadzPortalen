using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Ledion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d8f7cfa-6c63-4795-8406-660dc3a5e9b0", "AQAAAAEAACcQAAAAEF6oFKaPYv7dY6S49UYErceG71LgqY4NQnl65ID7GEx1UAcL7IeuWnI1fBAGgW6Aow==", "32aa14d5-67e0-42a5-8d79-7a541b5b5536" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d43bca50-ba9e-43a9-9696-9eb91912f49e", "AQAAAAEAACcQAAAAEF6oFKaPYv7dY6S49UYErceG71LgqY4NQnl65ID7GEx1UAcL7IeuWnI1fBAGgW6Aow==", "8bf0484e-c504-43c0-865f-15e592c17374" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d16f73c8-9f8d-4dc7-9d47-e775caadb6a5", "AQAAAAEAACcQAAAAEF6oFKaPYv7dY6S49UYErceG71LgqY4NQnl65ID7GEx1UAcL7IeuWnI1fBAGgW6Aow==", "b2c08c00-a0f2-481a-ad52-74cf4207534f" });

            migrationBuilder.InsertData(
                table: "RealEstateAgencies",
                columns: new[] { "RealEstateAgencyId", "AgencyDescription", "AgencyLogoUrl", "AgencyName" },
                values: new object[,]
                {
                    { 3, "Sveriges näst bästa mäklarbyrå", "BilderKommerSen", "Gottfridsson" },
                    { 4, "Skåne är den bästa platsen på Gotland", "BilderKommerSen", "Skanebo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RealEstateAgencies",
                keyColumn: "RealEstateAgencyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RealEstateAgencies",
                keyColumn: "RealEstateAgencyId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a00a7dc2-12e2-4eba-9ef4-0b2924af18f6", "AQAAAAIAAYagAAAAEL0vK3u4uuq3akGY0qwVTB4KbPR7htWdXTwMNln/8bBEK96uV8y4Zual3NsCNFXffQ==", "527f3972-22a1-4e3b-84d6-139e933b4c97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb474526-ddf8-4fde-b2be-5af0aa40b782", "AQAAAAIAAYagAAAAEAVkvsHMZWFJT44Kt4H6U2bSYwzmEi3a8hWtI/BpuERnxDTZkyZKUwJKVMkhrSMdKg==", "2bb446e5-3db2-4c19-9fa4-79ec9a70128a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03251133-4d27-4778-855b-556b10885ff3", "AQAAAAIAAYagAAAAEACQOz8ifjb82lxqF1mYcvfg4lEo85VDFMP+0JRkIUWt7mjxRlJXw2QC++6t8yftXw==", "f2151a4a-7c0a-486f-8a52-55fd908ebbeb" });
        }
    }
}
