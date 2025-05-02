using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87efc5ac-77d8-4729-b3d6-3309dc88e88d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b623711-20a0-43bc-86d7-6750e27d6908", "AQAAAAIAAYagAAAAECCcm4SCos4G/Zk8Nq6EZo7Zj6NpbnG6Af8gRxkz//tlJq/g8PcwmUGZ/olz+Tz6xA==", "8fd4cd67-dbd0-4253-a687-b9274d260b36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3b926ba-5566-4717-a708-7eab60346e88", "AQAAAAIAAYagAAAAEG8EfqlCam61lXie2Xz27mf8Cly/NTyTHGyyCnGjR7hgnuPKK46a7yBh96IQHYPN6w==", "6f75a2d4-6445-4830-9b4d-bf9cdcaddccd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bec3f0c9-734a-4ee0-93a1-f4fa2fe392e7", "AQAAAAIAAYagAAAAEB83oXtJabzptZgJoruqbN4jI3xcqVzkZ5RYnouvNeKEBglSo33ePiC0O+1wxdelew==", "d548c8a3-9575-4282-8ab2-aa766d5b9528" });
        }
    }
}
