using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyImages_PropertiesForSale_PropertyForSaleId",
                table: "PropertyImages");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyForSaleId",
                table: "PropertyImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyImages_PropertiesForSale_PropertyForSaleId",
                table: "PropertyImages",
                column: "PropertyForSaleId",
                principalTable: "PropertiesForSale",
                principalColumn: "PropertyForSaleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyImages_PropertiesForSale_PropertyForSaleId",
                table: "PropertyImages");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyForSaleId",
                table: "PropertyImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b45c81aa-d788-45a6-b58d-ff300b204a93", "AQAAAAIAAYagAAAAENrimS8n51u0Va6ezyA9KUYqkFvau+JsO9kWI2J2vtqXqyb4QZ6YGo9IGYH1c+5cQg==", "16b30e5d-9e99-4166-a988-41bf1cc1483e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9e04b00-0919-4fa6-92fa-9c50400f1a0f", "AQAAAAIAAYagAAAAEMixM2b5MELMxs9KCT4UbxXGDKQIFI6jZe6LDQW30QCs/Q8PSO2nuKOrD/EH5KxekQ==", "eccf9d8a-edd3-434c-83ad-9182c9edb3ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af6e9852-74e3-4a67-ab8c-ab78658af7b3", "AQAAAAIAAYagAAAAECph8PjT1SWfPr8hDgHnnB2yuxQqopj2+OuHzvlrvQZ8MweihkBHAXIu6trgAdI4bQ==", "e75480b5-0e17-4585-848a-f43c1aa1dbf7" });

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyImages_PropertiesForSale_PropertyForSaleId",
                table: "PropertyImages",
                column: "PropertyForSaleId",
                principalTable: "PropertiesForSale",
                principalColumn: "PropertyForSaleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
