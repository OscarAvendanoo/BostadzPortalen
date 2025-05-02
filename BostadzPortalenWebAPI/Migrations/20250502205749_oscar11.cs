using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
