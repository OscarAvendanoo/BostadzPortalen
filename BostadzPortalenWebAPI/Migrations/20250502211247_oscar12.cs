using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed481644-2588-41b5-87e0-b3a377fa2606", "AQAAAAIAAYagAAAAEBp8JErSFakVlL+T81TQC7WET0w3g7fmYMP0tvvdyMK6dJ9fzYb/tpYLS/plU/o19w==", "46614f7b-c59a-4bf2-8dbb-40ef323e9289" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b1bb5b5-f95c-4686-82df-c412b1b7298c", "AQAAAAIAAYagAAAAEJR4oRw2wU5oDf/b6iWW9jACVN2qvGtSx0Q8s4aMMiwonOnAaFqBDtat12aXcWWAaA==", "fea34bbc-bf5c-4cb6-9279-94b931307330" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0feda4bb-cf32-4d7c-bed3-4edf20325565", "AQAAAAIAAYagAAAAEN3NrygZ9z0I94auHBZo3IHTGLvYT240RBvZvZpvaL663maWOB8afxFO3+Knb7YDUw==", "2627072d-277b-4899-ac73-157f88173a8e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25cff0a9-bde6-4594-a43f-5d00ff5b349d", "AQAAAAIAAYagAAAAEMI3njGqRQG3RHWw+x8B0PLHxHudNRoVtba+BOveC7K/og/Kq9VS7/5htVwlDmZqnQ==", "a572795c-4d99-459b-8a6f-8b05cd2428e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16a1af1c-7303-4820-866e-5065e4d77991", "AQAAAAIAAYagAAAAENBcllhzyvEypB1rxMYeWshZd9sSFnWVzET6PyD4La3lgRCMyz8/3zFWF4KVEe33nw==", "deb131e9-302a-4e76-a9b7-0fd103d99c99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9feb446-f051-4e86-b621-147dc355b606", "AQAAAAIAAYagAAAAEJpE/6A8x292coLMYs9pm1vOHCrQo+M7L/Lc7bk51tGJOMfIPvlGu0u9DH9F2XXrZA==", "0b984389-8936-4e02-aa6e-ee3231d4dd10" });
        }
    }
}
