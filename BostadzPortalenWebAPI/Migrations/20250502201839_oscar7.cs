using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deb18c8a-d992-41bb-b00c-a60f0a8fb2fb", "AQAAAAIAAYagAAAAEBUGNNJhFhLmr7UbgczfeRV9LVwjUHe0uGNlUeXQntncK0trIG44KJHyIOdVdL95xQ==", "05d81974-b4ab-489e-b819-94587c4fa908" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61f7986b-0f40-42a3-9d3a-5e8e6a15be37", "AQAAAAIAAYagAAAAEK/ZuHg2mg/lOtDfQAdm1yrMPPyGir9qUuXzU2bgYTcPYf2qyuaFuO7OYVQSWypYXw==", "df3dde4e-c9b6-4d9b-8c8d-d3a502330d9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bf82cd4-516e-4009-93ff-1932c8795cde", "AQAAAAIAAYagAAAAEKEAr9gW8aJf9eh0qCjvSTzoWRqI+sfZ4tIlkUhaWaJr/aCCM7m1T33L0dR21fuhMA==", "79939f03-d077-4903-b7cd-7a641fc05afa" });
        }
    }
}
