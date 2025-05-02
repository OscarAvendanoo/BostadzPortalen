using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class oscar13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
