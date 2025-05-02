using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar8 : Migration
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

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyImages_PropertiesForSale_PropertyForSaleId",
                table: "PropertyImages",
                column: "PropertyForSaleId",
                principalTable: "PropertiesForSale",
                principalColumn: "PropertyForSaleId",
                onDelete: ReferentialAction.Cascade);
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
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bece5275-9e10-41e5-ba34-dd16ddc78ceb", "AQAAAAIAAYagAAAAELyamLZEVglDxi3bzDO/6O/j45k2ZDXEmWw5DFGw2moDKTnm/Drrc/WK5+ArFb0mdA==", "f19b5c8b-27e9-4a25-9412-24b8f4f3b7c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96af5d17-59b9-42fc-bec5-dda182d4e0e0", "AQAAAAIAAYagAAAAEBBXvGvecMgHFFB6ZsGxMM6nkEh7Gi6X8CDdI7TEs1va4qCAU7Bjj0UWoonf+1a6lA==", "67ce5fb0-0846-4e30-9912-a5c4a41ed57a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0ce2c1a-cd33-4cf9-85e5-b3130ee9214c", "AQAAAAIAAYagAAAAELnVqjOLcukMBefYIPUqvF3LqAAIivqhYUvKFxoYELt/xqrh+HSJf2jA5rEqDLlSPQ==", "d6e593c1-8f65-48c4-b69c-0537420467f9" });

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyImages_PropertiesForSale_PropertyForSaleId",
                table: "PropertyImages",
                column: "PropertyForSaleId",
                principalTable: "PropertiesForSale",
                principalColumn: "PropertyForSaleId");
        }
    }
}
