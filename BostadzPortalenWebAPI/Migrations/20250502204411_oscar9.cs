using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d6a770d-0242-4e90-a353-2096f554afeb", "AQAAAAIAAYagAAAAEAkNEMjJCqJUzrf4mN97Ex+oNVEeP25pwUHu5e0pLN/4asoHtXlb3DZg6ZuL/IDMFQ==", "6d88eb3c-e233-4666-b2f1-5d15d3224e15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9e9bf59-295f-4d47-8086-a7b89d6e7ea1", "AQAAAAIAAYagAAAAEPjC2HzRznNhUQsWMnLle46r7VI202Ya5deI+g56YQEjUBTMPUCjZ1VB9oP7XwM/1Q==", "927ff86f-4c7a-4979-a12f-5b3b2df57626" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08d70ad0-fb12-4047-a20f-f09844e663ef", "AQAAAAIAAYagAAAAEIis9GwuXE8P3QjLxAfmE9lv5jLyKSfwX2OpA8Wdcb3AXk7waCCgFQ9iyXk25cHnHg==", "6dc584bc-bc0a-4144-a207-40cc4298e694" });

            migrationBuilder.InsertData(
                table: "PropertiesForSale",
                columns: new[] { "PropertyForSaleId", "Address", "AskingPrice", "Description", "LivingArea", "MonthlyFee", "MunicipalityId", "NumberOfRooms", "PlotArea", "RealtorId", "SupplementaryArea", "TypeOfProperty", "YearBuilt", "YearlyOperatingCost" },
                values: new object[,]
                {
                    { 1, "Wanker Street 69", 500000m, "It's a place to live", 24, 5000m, 1, 1, 8, "92b88e50-795f-4df6-90e0-8a7d9a179cb0", 8, 0, 1999, 1000m },
                    { 2, "Kungsgatan 4", 1000000m, "Fin utsikt", 24, 10000m, 2, 1, 8, "87efc5ac-77d8-4729-b3d6-3309dc88e88d", 8, 0, 1999, 1000m },
                    { 3, "Kungsgatan 16", 7000000m, "Bättre än kungsgatan 4", 64, 10000m, 2, 4, 8, "87efc5ac-77d8-4729-b3d6-3309dc88e88d", 8, 2, 1950, 1000m }
                });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "Id", "ImageUrl", "PropertyForSaleId" },
                values: new object[,]
                {
                    { 1, "https://bcdn.se/cache/46826101_1440x0.webp", 1 },
                    { 2, "https://bcdn.se/cache/46749115_1440x0.webp", 1 },
                    { 3, "https://bilder.hemnet.se/images/itemgallery_cut/92/07/92072bcf74b368123df41d4270bae949.jpg", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertiesForSale",
                keyColumn: "PropertyForSaleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertiesForSale",
                keyColumn: "PropertyForSaleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertiesForSale",
                keyColumn: "PropertyForSaleId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36fbbdba-6339-4408-9499-2816e74b228f", "AQAAAAIAAYagAAAAEGzIEfMunfktptWS8CiflrnDftZ5bCyK4yIolFz2Qc85LkjzQfqfQuiLE5TnCCRoYw==", "9a07347d-05ce-4440-85ca-22f1958652b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ed001e9-366d-433b-9dd5-bdef33638dd3", "AQAAAAIAAYagAAAAEBDujrAn+eY37OZ+pdIx1WS+2IrkfCRvDkUjLfqCC+6NSwkYhOKHkMNRAqxYuygFFw==", "75d467bd-a85d-4b8d-bf70-0c7cce3e7834" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3b03895-2eb0-4fd3-b276-a6f3584b0302", "AQAAAAIAAYagAAAAEId+lr3vNv6I9eTN/bsy5GXp+U+ZfOToUvWeARwJUsSJwXWPFIvRq2Y+gx49TA7Acg==", "bb6ae9f4-7fb3-4cfc-b8b7-5c1e338e166c" });
        }
    }
}
