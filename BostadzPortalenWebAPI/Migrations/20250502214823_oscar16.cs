using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a08f3710-00ee-4032-9e52-c93eb9fb73c1", "AQAAAAIAAYagAAAAEPTyeAjTGI4BkTnB8qcONi1UIJf4DpG+BMyVhzCPql0mjBuaWKtS1r7bUOmqqR87nA==", "1cde42e0-2fa4-4a71-bcec-452e1954db0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13984f94-2f39-4aa4-b2ef-c4e021ffc17b", "AQAAAAIAAYagAAAAEHedQESDgA/002ERcR4HuSoCiRd4fsLbjoIK3yb2z7PRt9wci9mk1TOgYBy4lDIubQ==", "000af66e-0235-4ef7-81ba-091ce6c0be5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ea49932-b5b2-44a6-bece-0a8ff63e8590", "AQAAAAIAAYagAAAAEGk+fl/c3Qgjli+MQCojbfcCbtnw4pGjzIZ7aI4BorD+hQSTxbs2rOSgLz+F8lHyiQ==", "0379813f-715e-40bb-b7b1-bd05aea31480" });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "PropertyForSaleId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "PropertyForSaleId",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "PropertyForSaleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "PropertyForSaleId",
                value: 2);
        }
    }
}
