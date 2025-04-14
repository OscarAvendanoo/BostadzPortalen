using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RealEstateAgencies",
                columns: table => new
                {
                    RealEstateAgencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgencyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgencyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgencyLogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealEstateAgencies", x => x.RealEstateAgencyId);
                });

            migrationBuilder.CreateTable(
                name: "Realtors",
                columns: table => new
                {
                    RealtorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realtors", x => x.RealtorId);
                    table.ForeignKey(
                        name: "FK_Realtors_RealEstateAgencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "RealEstateAgencies",
                        principalColumn: "RealEstateAgencyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertiesForSale",
                columns: table => new
                {
                    PropertyForSaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MunicipalityId = table.Column<int>(type: "int", nullable: false),
                    AskingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LivingArea = table.Column<double>(type: "float", nullable: false),
                    SupplementaryArea = table.Column<double>(type: "float", nullable: false),
                    PlotArea = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: false),
                    MonthlyFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    YearlyOperatingCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YearBuilt = table.Column<int>(type: "int", nullable: false),
                    RealtorId = table.Column<int>(type: "int", nullable: false),
                    TypeOfProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertiesForSale", x => x.PropertyForSaleId);
                    table.ForeignKey(
                        name: "FK_PropertiesForSale_Municipalities_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertiesForSale_Realtors_RealtorId",
                        column: x => x.RealtorId,
                        principalTable: "Realtors",
                        principalColumn: "RealtorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrepertyImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyForSaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrepertyImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrepertyImages_PropertiesForSale_PropertyForSaleId",
                        column: x => x.PropertyForSaleId,
                        principalTable: "PropertiesForSale",
                        principalColumn: "PropertyForSaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrepertyImages_PropertyForSaleId",
                table: "PrepertyImages",
                column: "PropertyForSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertiesForSale_MunicipalityId",
                table: "PropertiesForSale",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertiesForSale_RealtorId",
                table: "PropertiesForSale",
                column: "RealtorId");

            migrationBuilder.CreateIndex(
                name: "IX_Realtors_AgencyId",
                table: "Realtors",
                column: "AgencyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrepertyImages");

            migrationBuilder.DropTable(
                name: "PropertiesForSale");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "Realtors");

            migrationBuilder.DropTable(
                name: "RealEstateAgencies");
        }
    }
}
