using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e0bc1c8-bee8-4a2d-a93d-742cb668e89d", "AQAAAAIAAYagAAAAEGSWEclUH4pAjfdVDd4sN5SAeX/gipVr7kkzcuAxl1UAhB1PAn1AhVo2OPJ3jyZnvg==", "439eb904-eaee-48ac-a60e-abf392d1b31e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ab016d0-eb6e-47bc-a0e5-9bad4352cedf", "AQAAAAIAAYagAAAAEGKVJkmeTBZ6+U2IFyf13ewPz1BpTBMJQNRyyEUlWfcP29AqAK/uUbqO0Hp4RQHDpw==", "fb56bf4d-08f5-49a5-931d-2327e137df61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5dfe48d-b2c9-4843-9b20-01f4d6c7d046", "AQAAAAIAAYagAAAAEI3qGPx4RRnR2J6zp5+wKWtxE8kJLb9OCog4JsNv5lgKdE4uFz+W0gERJi2fc9A/7g==", "e1a39e5d-54e8-428f-825f-16a7432831c1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbce86a2-232f-4b80-b574-533cddae8cb5", "AQAAAAIAAYagAAAAECQ0naBet9itTLJt0uiCSFwJWPUryAOd99Uvl6eQexSvElpIiyD/Swt4gitR7RCZWg==", "f611ebda-475a-4942-aa72-ace0813310aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad17c050-103d-4680-9a55-6106123029a7", "AQAAAAIAAYagAAAAEGJtVDOxU/6Fsgmklz4NoL37L3QL13zcNHf4GUvLX5TCvOol2u/046YikYWnz+jS6w==", "fb9c8724-2659-404b-97b7-47bc2f3badcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d35bc18-67fd-4420-a817-c4a037d2b99d", "AQAAAAIAAYagAAAAEJvu3HNDFSKnOWzfdsbTQAM1Mt2QB7FaEpMLhE+Pqx3Wn9IsHUtAWhtssDdoJeWVUg==", "69ec4712-599d-4aaf-8207-0036d1a5aa6d" });
        }
    }
}
