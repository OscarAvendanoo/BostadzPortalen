using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afe2f8b4-f89c-4bb6-8c67-6ffff1bb236a", "AQAAAAIAAYagAAAAEG3ecoDKx/dfYm3104sMUiFcXuzSU2oeWT4Im8FPbzzdzrwieJ5echrg5VIY8+D52w==", "c70b9504-cc7a-4e85-9863-a3d679a2ef80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a02d245a-f866-4f9b-bf70-4a89673e9907", "AQAAAAIAAYagAAAAENlDCZFSXpLaJMqMGf57cpb+8S+fIARD+ZIxbZt42doMLZv9LLda7/iYZrZk54SJHA==", "61209ce3-0233-464d-91b1-097e50f8ad2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abfe729e-179f-4c1e-9f22-b059f62cab1a", "AQAAAAIAAYagAAAAECNeRLQHyTm0MjaKqi43P7UVhJy2fVTG0gctcSICKWHmHSCMu7y7QsDPmy0bpXSmqQ==", "acadf4bb-37df-4722-8423-13fb54cf0ec6" });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://bilder.hemnet.se/images/itemgallery_cut/8c/db/8cdb9b8866cc65d5ec941a56b31ba634.jpg");

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://bilder.hemnet.se/images/itemgallery_cut/8c/db/8cdb9b8866cc65d5ec941a56b31ba634.jpg");

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://bilder.hemnet.se/images/itemgallery_cut/8c/db/8cdb9b8866cc65d5ec941a56b31ba634.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://bcdn.se/cache/46826101_1440x0.webp");

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://bcdn.se/cache/46749115_1440x0.webp");

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://bilder.hemnet.se/images/itemgallery_cut/92/07/92072bcf74b368123df41d4270bae949.jpg");
        }
    }
}
