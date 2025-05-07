using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e7770b0-7719-4257-906f-cc725fb5038a", "AQAAAAIAAYagAAAAEDD1gf5BdBmAVAOGWGNW7X6cbFoSezihX84mX/1N8pqgn9vb567NEkYRnNN/zDEsBg==", "38ec6d3f-0347-4375-8202-551844f20a8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08636f0b-1956-44e1-9240-ea20da15816c", "AQAAAAIAAYagAAAAEK5hTVIBHQcReT9hkUwlgZkg8sXvj0lKBIBmmZ5ok5311T3khCfCQ2HuhVs1JEVhOg==", "f64bb31d-2be7-4a0e-9ab0-1ac661edd3c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f41f399-7164-4d67-9ae9-8cb05f531d00", "AQAAAAIAAYagAAAAEI9VbUHr0/69E1hbzWvlbMleYwyF2jSsvfQJcWP04tEC/4xUgoRxKVksK43BWTtYfQ==", "9ddca907-c667-4cfe-a86b-64459311f878" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15a14eed-2cea-4f47-be33-bb21f5604d24", "AQAAAAIAAYagAAAAEEO5EyjKdBNNgnOSI/8Yif8WA0lV2/+ydYEFfPJpUpIWqKf4O2wvD8YOxdrkElQk/g==", "f8afa92e-5a01-4348-92d6-636f45f0dcc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49adb663-04fd-404a-978a-af2ae7772fc0", "AQAAAAIAAYagAAAAEFWPCp0bxO43AVReUQVMkTaLuyiYyVTkAJIilgo/RxTTVrdjEz3LDuwSTo4uzVp25Q==", "212d58f4-526b-486b-a64d-0639ae6db234" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98c056e3-88b3-4ba0-9bf0-17a77ec4708d", "AQAAAAIAAYagAAAAEMEynk6/zZ7p7L4qC5672zNnETR+Zl4jcV1DOXV7yvPn4Ub+Z3KLqRTVpTvHsgHh9w==", "754f9208-6e36-466a-997d-b95f2d6858c1" });
        }
    }
}
