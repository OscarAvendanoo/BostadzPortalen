using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgencyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_RealEstateAgencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "RealEstateAgencies",
                        principalColumn: "RealEstateAgencyId");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
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
                    SupplementaryArea = table.Column<double>(type: "float", nullable: true),
                    PlotArea = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: false),
                    MonthlyFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    YearlyOperatingCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YearBuilt = table.Column<int>(type: "int", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RealtorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TypeOfProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertiesForSale", x => x.PropertyForSaleId);
                    table.ForeignKey(
                        name: "FK_PropertiesForSale_AspNetUsers_RealtorId",
                        column: x => x.RealtorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertiesForSale_Municipalities_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyForSaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyImages_PropertiesForSale_PropertyForSaleId",
                        column: x => x.PropertyForSaleId,
                        principalTable: "PropertiesForSale",
                        principalColumn: "PropertyForSaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", null, "Realtor", "REALTOR" },
                    { "e11cc563-5369-471e-9792-6255e0d08eaf", null, "Administrator", "ADMINISTRATOR" },
                    { "e6ae5d04-8f49-4b62-bc52-205353eb08dc", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AgencyId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "87efc5ac-77d8-4729-b3d6-3309dc88e88d", 0, null, "57a0eebb-d7a1-47bf-abbd-8c7216a56606", "Realtor", "hashed@demoapi.com", true, "Hashed", "User", false, null, "HASHED@DEMOAPI.COM", "HASHED@DEMOAPI.COM", "AQAAAAIAAYagAAAAEMdXVdbkyXMkVqfHqkqF6AfgeVxYOOdJpvgnEf3Yta44BdSd3tMcDec79i/C3TYA2A==", "0722661922", false, null, "5ea24270-7865-49c1-a497-07a9b575a0e8", false, "hashed@demoapi.com" },
                    { "92b88e50-795f-4df6-90e0-8a7d9a179cb0", 0, null, "e034f68f-dab2-476e-a140-32c84c032bbc", "Realtor", "user@demoapi.com", true, "System", "User", false, null, "USER@DEMOAPI.COM", "USER@DEMOAPI.COM", "AQAAAAIAAYagAAAAEFijB/Z0QU8mRE5kfpjArHQDGsgjLMx0GXCljNd3Sg+F/tznlHrQ3+Li6EWmRApXGw==", "0722661922", false, null, "8bae1874-fc91-4605-ad99-4418f20a2c3a", false, "user@demoapi.com" },
                    { "92d637e6-6a8d-421e-a118-7a29d0edc1e7", 0, null, "14a23368-3049-4a8f-8928-5ad2db1268ac", "Realtor", "admin@demoapi.com", true, "System", "Admin", false, null, "ADMIN@DEMOAPI.COM", "ADMIN@DEMOAPI.COM", "AQAAAAIAAYagAAAAEPRrA+z2V4XVE47d6ErGOt4tAuqkN1MIZgNzUM1mFnM8Jw+Mnyi4ddRRngz2mBpIWA==", "0722661920", false, null, "ec3bc18e-b232-4274-863b-e3f1d654fa8e", false, "admin@demoapi.com" }
                });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Umeå" },
                    { 2, "Stockholm" }
                });

            migrationBuilder.InsertData(
                table: "RealEstateAgencies",
                columns: new[] { "RealEstateAgencyId", "AgencyDescription", "AgencyLogoUrl", "AgencyName" },
                values: new object[,]
                {
                    { 1, "Sveriges näst bästa mäklarbyrå", "BilderKommerSen", "Gottfridsson" },
                    { 2, "Skåne är den bästa platsen på Gotland", "BilderKommerSen", "Skanebo" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e6ae5d04-8f49-4b62-bc52-205353eb08dc", "87efc5ac-77d8-4729-b3d6-3309dc88e88d" },
                    { "e6ae5d04-8f49-4b62-bc52-205353eb08dc", "92b88e50-795f-4df6-90e0-8a7d9a179cb0" },
                    { "e11cc563-5369-471e-9792-6255e0d08eaf", "92d637e6-6a8d-421e-a118-7a29d0edc1e7" }
                });

            migrationBuilder.InsertData(
                table: "PropertiesForSale",
                columns: new[] { "PropertyForSaleId", "Address", "AskingPrice", "Description", "ImageUrls", "LivingArea", "MonthlyFee", "MunicipalityId", "NumberOfRooms", "PlotArea", "RealtorId", "SupplementaryArea", "TypeOfProperty", "YearBuilt", "YearlyOperatingCost" },
                values: new object[,]
                {
                    { 1, "Wanker Street 69", 500000m, "It's a place to live", "[]", 24.0, 5000m, 1, 1, 8.0, "92b88e50-795f-4df6-90e0-8a7d9a179cb0", 8.0, 0, 1999, 1000m },
                    { 2, "Kungsgatan 4", 1000000m, "Fin utsikt", "[]", 24.0, 10000m, 2, 1, 8.0, "87efc5ac-77d8-4729-b3d6-3309dc88e88d", 8.0, 0, 1999, 1000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AgencyId",
                table: "AspNetUsers",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PropertiesForSale_MunicipalityId",
                table: "PropertiesForSale",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertiesForSale_RealtorId",
                table: "PropertiesForSale",
                column: "RealtorId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyImages_PropertyForSaleId",
                table: "PropertyImages",
                column: "PropertyForSaleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PropertyImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "PropertiesForSale");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "RealEstateAgencies");
        }
    }
}
