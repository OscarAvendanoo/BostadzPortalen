using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class jn8 : Migration
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
                    LivingArea = table.Column<int>(type: "int", nullable: false),
                    SupplementaryArea = table.Column<int>(type: "int", nullable: false),
                    PlotArea = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: false),
                    MonthlyFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YearlyOperatingCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YearBuilt = table.Column<int>(type: "int", nullable: false),
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
                    { 1, "Sveriges näst bästa mäklarbyrå", "https://driftservice.blob.core.windows.net/agency-home-solution/5f946ff9-b99b-4e50-96f8-492a34ccbd47_logo", "Gottfridsson" },
                    { 2, "Skåne är den bästa platsen på Gotland", "https://fatcamp.io/xn--mklare-bua.se/images/artiklar/makl.samfundet.jpg?width=1000", "Skanebo" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AgencyId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "87efc5ac-77d8-4729-b3d6-3309dc88e88d", 0, 2, "a00a7dc2-12e2-4eba-9ef4-0b2924af18f6", "Realtor", "realtor@demoapi.com", true, "System", "Realtor", false, null, "REALTOR@DEMOAPI.COM", "REALTOR@DEMOAPI.COM", "AQAAAAIAAYagAAAAEL0vK3u4uuq3akGY0qwVTB4KbPR7htWdXTwMNln/8bBEK96uV8y4Zual3NsCNFXffQ==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/d8/50/d850bd83227eb78f123af53871614efd.jpg", "527f3972-22a1-4e3b-84d6-139e933b4c97", false, "realtor@demoapi.com" },
                    { "92b88e50-795f-4df6-90e0-8a7d9a179cb0", 0, 1, "eb474526-ddf8-4fde-b2be-5af0aa40b782", "Realtor", "user@demoapi.com", true, "System", "User", false, null, "USER@DEMOAPI.COM", "USER@DEMOAPI.COM", "AQAAAAIAAYagAAAAEAVkvsHMZWFJT44Kt4H6U2bSYwzmEi3a8hWtI/BpuERnxDTZkyZKUwJKVMkhrSMdKg==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/9b/10/9b10a04e47ec5804594aef06016ceb5b.jpg", "2bb446e5-3db2-4c19-9fa4-79ec9a70128a", false, "user@demoapi.com" },
                    { "92d637e6-6a8d-421e-a118-7a29d0edc1e7", 0, 1, "03251133-4d27-4778-855b-556b10885ff3", "Realtor", "admin@demoapi.com", true, "System", "Admin", false, null, "ADMIN@DEMOAPI.COM", "ADMIN@DEMOAPI.COM", "AQAAAAIAAYagAAAAEACQOz8ifjb82lxqF1mYcvfg4lEo85VDFMP+0JRkIUWt7mjxRlJXw2QC++6t8yftXw==", "0722661920", false, "https://genslerzudansdentistry.com/wp-content/uploads/2015/11/anonymous-user.png", "f2151a4a-7c0a-486f-8a52-55fd908ebbeb", false, "admin@demoapi.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "87efc5ac-77d8-4729-b3d6-3309dc88e88d" },
                    { "e6ae5d04-8f49-4b62-bc52-205353eb08dc", "92b88e50-795f-4df6-90e0-8a7d9a179cb0" },
                    { "e11cc563-5369-471e-9792-6255e0d08eaf", "92d637e6-6a8d-421e-a118-7a29d0edc1e7" }
                });

            migrationBuilder.InsertData(
                table: "PropertiesForSale",
                columns: new[] { "PropertyForSaleId", "Address", "AskingPrice", "Description", "LivingArea", "MonthlyFee", "MunicipalityId", "NumberOfRooms", "PlotArea", "RealtorId", "SupplementaryArea", "TypeOfProperty", "YearBuilt", "YearlyOperatingCost" },
                values: new object[,]
                {
                    { 1, "Wanker Street 69", 500000m, "It's a place to live", 24, 5000m, 1, 1, 8, "92b88e50-795f-4df6-90e0-8a7d9a179cb0", 8, 0, 1999, 1000m },
                    { 2, "Kungsgatan 4", 1000000m, "Fin utsikt", 24, 10000m, 2, 1, 8, "87efc5ac-77d8-4729-b3d6-3309dc88e88d", 8, 0, 1999, 1000m },
                    { 3, "Kungsgatan 16", 7000000m, "Bättre än kungsgatan 4", 64, 10000m, 2, 4, 8, "87efc5ac-77d8-4729-b3d6-3309dc88e88d", 8, 2, 1950, 1000m }
                });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "Id", "ImageUrl", "PropertyForSaleId" },
                values: new object[,]
                {
                    { 1, "https://bilder.hemnet.se/images/itemgallery_cut/8c/db/8cdb9b8866cc65d5ec941a56b31ba634.jpg", 1 },
                    { 2, "https://bilder.hemnet.se/images/itemgallery_cut/40/f5/40f595711fdb0cc0ebdbd5ee80be8929.jpg", 2 },
                    { 3, "https://bilder.hemnet.se/images/itemgallery_cut/89/89/898947735c6b46af72a4556dabadf07a.jpg", 3 },
                    { 4, "https://bilder.hemnet.se/images/itemgallery_cut/09/e2/09e29480a003367d9dc3b139de9c416d.jpg", 1 },
                    { 5, "https://qasa-static-prod.s3-eu-west-1.amazonaws.com/img/5c5dd162d2ac084603a87e1c8d9f16bd1d93039a57b06ddca34f8aee46e4b88e.jpg", 2 },
                    { 6, "https://bcdn.se/images/cache/33121851_960x640.jpg", 3 }
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
