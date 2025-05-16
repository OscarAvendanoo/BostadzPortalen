using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BostadzPortalenWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class jnupdatedemails : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 100000, nullable: false),
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
                    PropertyForSaleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyImages_PropertiesForSale_PropertyForSaleId",
                        column: x => x.PropertyForSaleId,
                        principalTable: "PropertiesForSale",
                        principalColumn: "PropertyForSaleId");
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
                    { 2, "Stockholm" },
                    { 3, "Luleå" },
                    { 4, "Malmö" },
                    { 5, "Göteborg" },
                    { 6, "Visby" },
                    { 7, "Sundsvall" },
                    { 8, "Gävle" },
                    { 9, "Skellefteå" },
                    { 10, "Örnsköldsvik" },
                    { 11, "Uppsala" }
                });

            migrationBuilder.InsertData(
                table: "RealEstateAgencies",
                columns: new[] { "RealEstateAgencyId", "AgencyDescription", "AgencyLogoUrl", "AgencyName" },
                values: new object[,]
                {
                    { 1, "Admin Agency", "", "ADMIN ONLY" },
                    { 2, "Vi är Sveriges största mäklarkedja och stolta över att vara en del av Swedbank. Med över 300 kontor över hela landet erbjuder vi trygghet, lokal expertis och ett stort nätverk som gör din bostadsaffär smidig och säker. Vår passion är att hjälpa dig hitta rätt – oavsett om du ska köpa eller sälja.", "https://bilder.hemnet.se/images/broker_logo_2_2x/3d/53/3d53972640f121199879bf779e590c7d.jpg", "Fastighetsbyrån" },
                    { 3, "Hos oss får du mer än bara en mäklare – du får en trygg partner. Som en del av Länsförsäkringar-koncernen kombinerar vi djup lokal kunskap med försäkrings- och banktjänster, vilket ger dig en heltäckande och säker bostadsaffär. Vi finns nära dig för att göra bostadsdrömmen till verklighet.", "https://bilder.hemnet.se/images/broker_logo_2/73/c6/73c63376473b74a25e13711a82fcae60.png", "Länsförsäkringar Fastighetsförmedling" },
                    { 4, "Vi är en av Sveriges äldsta och mest pålitliga mäklarkedjor med ett starkt fokus på kundnöjdhet. Med vår stora erfarenhet och omfattande marknadsföring når vi ut till rätt köpare snabbt – så att du får bästa möjliga pris och en trygg försäljningsprocess.", "https://bilder.hemnet.se/images/broker_logo_2/73/80/7380eae8e412bea23a30d7cdd416f750.png", "Svensk Fastighetsförmedling" },
                    { 5, "Vi är din personliga och engagerade mäklare med hjärtat i den lokala marknaden. Genom nära kundkontakt och skräddarsydd rådgivning ser vi till att din bostadsaffär blir så trygg och framgångsrik som möjligt. Vårt mål är att göra dig nöjd – varje steg på vägen.\r\n\r\n", "https://bilder.hemnet.se/images/broker_logo_2_2x/dd/7a/dd7a02fb5c0324de279ace72e14b873c.png", "SkandiaMäklarna" },
                    { 6, "Välkommen till en mäklarkedja som sätter dig i fokus! Vi kombinerar rikstäckande närvaro med djup lokal expertis för att göra din bostadsaffär enkel, trygg och lönsam. Hos oss får du alltid personlig service och rådgivning anpassad efter dina behov.", "https://bilder.hemnet.se/images/broker_logo_2_2x/68/41/684184dc02af90e4f9d2ac612122b24f.png", "Mäklarhuset" },
                    { 7, "Med över 20 års erfarenhet är vi en av Sveriges mest pålitliga och fristående mäklarkedjor. Vi brinner för att ge dig personlig service och lokalkännedom i världsklass, så att du kan känna dig trygg och nöjd genom hela bostadsresan.", "https://bilder.hemnet.se/images/broker_logo_2_2x/ff/d0/ffd046756118f2684c2df1061d0185c4.png", "HusmanHagberg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AgencyId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a0ee7be-cde2-49bd-b48d-b675a4fbfbf0", 0, 5, "40a50ce5-3dcf-451e-a964-e811eca180de", "Realtor", "tore.wikander@skandiamaklarna.se", true, "Tore", "Wikander", false, null, "TORE.WIKANDER@SKANDIAMAKLARNA.SE", "TORE.WIKANDER@SKANDIAMAKLARNA.SE", "AQAAAAIAAYagAAAAEMJBLzP3zpA4FsslhkE6BlELwTXg6jrMK0FKjcXlJtNXdsQfaqOE9ARm0l8aIj8ImQ==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/f6/da/f6da5fe256d9d155fd6e291460c6f95b.jpg", "5b93be97-95b2-4894-bda9-360dd0075ac7", false, "tore.wikander@skandiamaklarna.se" },
                    { "144f56f5-10d1-4ab3-ab72-e917ec9cacc4", 0, 7, "43d7ed84-1445-42f1-99d7-6a058e07af06", "Realtor", "max.hjertqvist@husmanhagberg.com", true, "Max", "Hjertqvist", false, null, "MAX.HJERTQVIST@HUSMANHAGBERG.COM", "MAX.HJERTQVIST@HUSMANHAGBERG.COM", "AQAAAAIAAYagAAAAEBqjtOluAkb6HNjkrCPDclK+qvYQVW+AgKbirripZ4lMKkERSUKxZpSp9KXYUkcpWQ==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/c3/f1/c3f167f797358d672aa4c1d4b7ffc421.jpg", "e7456b81-2c1d-44ef-8892-4c77b8cac5f8", false, "max.hjertqvist@husmanhagberg.com" },
                    { "26f1c93b-0ce3-4655-a0e1-f0d91dbe6c71", 0, 3, "e1878d04-d8e1-4cad-8aa1-025447226c4e", "Realtor", "eric.svensson@lansforsakringar.se", true, "Eric", "Svensson", false, null, "ERIC.SVENSSON@LANSFORSAKRINGAR.SE", "ERIC.SVENSSON@LANSFORSAKRINGAR.SE", "AQAAAAIAAYagAAAAEDuEzXwiAMF29VCzfcwZKNwhKuDZmbiDjXmkvwebFmhaQE3WmO9Yte4SrWpzzlwXGg==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/28/49/2849c9de29bd992309e8e00aaec96d89.jpg", "d2d2e5c0-f3f9-41c3-95e0-ba5c122b3e5f", false, "eric.svensson@lansforsakringar.se" },
                    { "36cd14e4-aca3-4108-8120-42b5ffaee35f", 0, 5, "8c74d78a-b79c-46fb-abb8-5cc4eeb29a54", "Realtor", "gustav.azelius@skandiamaklarna.se", true, "Gustav", "Azelius", false, null, "GUSTAV.AZELIUS@SKANDIAMAKLARNA.SE", "GUSTAV.AZELIUS@SKANDIAMAKLARNA.SE", "AQAAAAIAAYagAAAAENgaZ6zDkrTJJBbRE6QW+Zp3GYeXk/eI93Uigqh3UVIKua1J/poTU8N7mxv3vMLWOw==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/f9/1e/f91ef13e8343b48609d5fc6462fc5b29.jpg", "068ae1b5-c3e1-41d6-ba9a-2a4913b3b2c9", false, "gustav.azelius@skandiamaklarna.se" },
                    { "66787f78-4dd5-4c82-917e-1bf99028a59a", 0, 4, "beacb037-12c0-4dca-a800-616f44fac157", "Realtor", "garifalia.diakakis@fastighetsformedling.se", true, "Garifalia", "Diakakis", false, null, "GARIFALIA.DIAKAKIS@FASTIGHETSFORMEDLING.SE", "GARIFALIA.DIAKAKIS@FASTIGHETSFORMEDLING.SE", "AQAAAAIAAYagAAAAEATguods4+ZXcv+ccglxLezE9KQdpFKRX3nbm7C0pxpF3Df2IHhpISsxfo2xlMjKag==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/9c/a7/9ca77f4a03c12493a14c2acf6400b7db.jpg", "56ec4fc0-3ee5-40b6-bc32-6e0c0b1a35a6", false, "garifalia.diakakis@fastighetsformedling.se" },
                    { "87efc5ac-77d8-4729-b3d6-3309dc88e88d", 0, 2, "a231d652-5c49-4ac3-bc3c-093a5a9b270f", "Realtor", "eric.hultman@fastighetsbyran.com", true, "Eric", "Hultman", false, null, "ERIC.HULTMAN@FASTIGHETSBYRAN.COM", "ERIC.HULTMAN@FASTIGHETSBYRAN.COM", "AQAAAAIAAYagAAAAELCejoawL/XNVSHYDeHyvkO9fNXR4eD7qb9YwRhUBBqkQO1HPvWk9Q8K5pnQYekSzw==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/c2/14/c214891aaaaa4cc23e4cbb57a9b95bbd.jpg", "e8f8c68f-4af5-4cae-91f4-75ea490b8799", false, "eric.hultman@fastighetsbyran.com" },
                    { "91858c77-9f96-4e67-8b4d-12065003247a", 0, 4, "8565ba3a-58bf-4579-a8c6-36a8f006cbbb", "Realtor", "frida.urciuoli@fastighetsformedling.se", true, "Frida", "Urciuoli", false, null, "FRIDA.URCIUOLI@FASTIGHETSFORMEDLING.SE", "FRIDA.URCIUOLI@FASTIGHETSFORMEDLING.SE", "AQAAAAIAAYagAAAAEHiXI2OYNIRC8wQuz73vJxLHsm0vUOE58br00GF6l07SM6uJHOtFCkYroz0U52wLsQ==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/3e/9f/3e9fed971ede79ae8654200a71105a3a.png", "b54d6622-5af0-4af8-b418-7a23e7770cb6", false, "frida.urciuoli@fastighetsformedling.se" },
                    { "92b88e50-795f-4df6-90e0-8a7d9a179cb0", 0, 2, "e0791bcb-f06d-4ba0-bcfe-6dc9cec3ebb8", "Realtor", "anders.johansson@fastighetsbyran.com", true, "Anders", "Johansson", false, null, "ANDERS.JOHANSSON@FASTIGHETSBYRAN.COM", "ANDERS.JOHANSSON@FASTIGHETSBYRAN.COM", "AQAAAAIAAYagAAAAEF9m0BVO/35IL2nCWII5baZEulpIN/AjvW9bBh5E31/J7+3KiCJrEjFFnjn5mJviwQ==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/dc/10/dc1096e4429f9ab94cb951c2361c1d2c.jpg", "20e0840b-a371-4c4e-a442-e1133caa478f", false, "anders.johansson@fastighetsbyran.com" },
                    { "92d637e6-6a8d-421e-a118-7a29d0edc1e7", 0, 1, "06250666-0b77-47b8-ab92-eceafbc00b5c", "Realtor", "admin@bostadzportalen.com", true, "System", "Admin", false, null, "ADMIN@BOSTADZPORTALEN.COM", "ADMIN@BOSTADZPORTALEN.COM", "AQAAAAIAAYagAAAAEFhVAwW0xIaJHnhxtDsO5QI6/0mVWQdeIFvO74u1mhbfxcul7EGi+QbSJRqFr8CivQ==", "0722661920", false, "https://genslerzudansdentistry.com/wp-content/uploads/2015/11/anonymous-user.png", "e30a120a-f130-4886-99b3-7f18e1c52371", false, "admin@bostadzportalen.com" },
                    { "a64ba80d-139c-4816-a169-9344e3d58e22", 0, 3, "5d556a94-69c5-48ff-9215-639f014f5a4d", "Realtor", "christopher.sjodahl@lansforsakringar.se", true, "Christopher", "Sjödahl", false, null, "CHRISTOPHER.SJODAHL@LANSFORSAKRINGAR.SE", "CHRISTOPHER.SJODAHL@LANSFORSAKRINGAR.SE", "AQAAAAIAAYagAAAAEBZo/Q/YKXfP4KSACJkWpbSzVzSuMhpIiBJ0bLBtlRHUufSytcbKv0cT2IDgRroCMQ==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/7e/0c/7e0ceb545d876de2c344463e3def2b2b.jpg", "26115386-03bc-4bc9-b4ab-c3676138d27a", false, "christopher.sjodahl@lansforsakringar.se" },
                    { "a7158f9e-8afb-4389-8e68-348450f4b6a9", 0, 6, "1e06c97a-7d17-4403-b378-9e25d62db49f", "Realtor", "louise.pedersen@maklarhuset.com", true, "Louise", "Pedersen", false, null, "LOUISE.PEDERSEN@MAKLARHUSET.COM", "LOUISE.PEDERSEN@MAKLARHUSET.COM", "AQAAAAIAAYagAAAAEKJNWQ7funcPy1T01CPJyE4wj86TMrbTrlRlLSUFx4KgwZGqz0LxwUYymkI9HeKOWQ==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/0d/69/0d69c1adc73cb71ec67c0e48fcd6bf09.png", "0988f697-859c-4eaf-8693-c02c119326a4", false, "louise.pedersen@maklarhuset.com" },
                    { "b03b6b66-a5fd-4fbc-a3f2-9c7202cbee60", 0, 3, "dbf160d3-2b0e-4237-9bfe-03428b3f860a", "Realtor", "asa.danielsson@lansforsakringar.se", true, "Åsa", "Danielsson", false, null, "ASA.DANIELSSON@LANSFORSAKRINGAR.SE", "ASA.DANIELSSON@LANSFORSAKRINGAR.SE", "AQAAAAIAAYagAAAAELgLuDgoXDYwgZNlmrh/GjrmT/x/Z+IWy1Gp4jeoCkOCTxOesLz+EYKlsDhH+eg2MQ==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/93/66/9366e20a447c16f1c7a25c264fe4afba.jpg", "3d788620-1c1a-4ff9-ae01-d16be22dc01f", false, "asa.danielsson@lansforsakringar.se" },
                    { "e7cde164-d981-41df-b3d9-35d42c0d8323", 0, 5, "3d3bb249-eba7-4acd-8b8f-36ca3d9de224", "Realtor", "alf.jonsson@skandiamaklarna.se", true, "Alf", "Jonsson", false, null, "ALF.JONSSON@SKANDIAMAKLARNA.SE", "ALF.JONSSON@SKANDIAMAKLARNA.SE", "AQAAAAIAAYagAAAAEP6kTXJWoxudF/A40GCilppkcmca733qOApJBYHMNWtXmL+nyF/PxcnH2Idu3kIHlw==", "0722661922", false, "https://bilder.hemnet.se/images/broker_profile_large/fb/e0/fbe05166921e291c40f9d5f22c2403ee.png", "188ed2d5-ef43-4f19-86a6-c74b3c44a1e1", false, "alf.jonsson@skandiamaklarna.se" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "0a0ee7be-cde2-49bd-b48d-b675a4fbfbf0" },
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "144f56f5-10d1-4ab3-ab72-e917ec9cacc4" },
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "26f1c93b-0ce3-4655-a0e1-f0d91dbe6c71" },
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "36cd14e4-aca3-4108-8120-42b5ffaee35f" },
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "66787f78-4dd5-4c82-917e-1bf99028a59a" },
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "87efc5ac-77d8-4729-b3d6-3309dc88e88d" },
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "91858c77-9f96-4e67-8b4d-12065003247a" },
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "92b88e50-795f-4df6-90e0-8a7d9a179cb0" },
                    { "e11cc563-5369-471e-9792-6255e0d08eaf", "92d637e6-6a8d-421e-a118-7a29d0edc1e7" },
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "a64ba80d-139c-4816-a169-9344e3d58e22" },
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "a7158f9e-8afb-4389-8e68-348450f4b6a9" },
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "b03b6b66-a5fd-4fbc-a3f2-9c7202cbee60" },
                    { "1e346bcf-ee97-4bb2-ab3e-8d7202fea078", "e7cde164-d981-41df-b3d9-35d42c0d8323" }
                });

            migrationBuilder.InsertData(
                table: "PropertiesForSale",
                columns: new[] { "PropertyForSaleId", "Address", "AskingPrice", "Description", "LivingArea", "MonthlyFee", "MunicipalityId", "NumberOfRooms", "PlotArea", "RealtorId", "SupplementaryArea", "TypeOfProperty", "YearBuilt", "YearlyOperatingCost" },
                values: new object[,]
                {
                    { 1, "Tallmovägen 10", 2295000m, "Välkomna till detta charmiga hus med en fantastisk trädgård och ett eftertraktat läge, bara fyra kilometer från centrala Obbola. Området erbjuder härliga promenadstråk och närhet till flera populära havsbadstränder, vilket gör detta till en idealisk plats att bo på.\r\nHuset rymmer fyra smakfulla rum, där köket flyter samman med vardagsrummet i en öppen planlösning – den perfekta ytan för samvaro. \r\nBadrummet är renoverat, och en praktisk, separat tvättstuga finns också att tillgå. Den generösa söderaltanen bjuder på sol hela dagen och en underbar utsikt över den insynsskyddade och välskötta trädgården.", 83, 0m, 1, 4, 1958, "92b88e50-795f-4df6-90e0-8a7d9a179cb0", 0, 2, 1971, 15827m },
                    { 2, "Svärdlångsvägen 19A", 1995000m, "Nu erbjuds möjligheten att förvärva denna välrenoverade etta där samtliga kvadratmeter är perfekt disponerade med imponerande takhöjd om 3.5m. Tack vare smart lösning med sovalkov direkt in till vänster får ni utan problem plats med soffgrupp med tillhörande möblemang, kontorshörna samt matbord för 4-6 personer. Med ett fullt utrustat kök, stambytt badrum samt ett fantastiskt ljusinsläpp från stora fönsterpartier är detta en lägenhet att trivas i. Genomgående fräscha ytskikt, här är det bara att flytta in. Byggnaderna ritades ursprungligen av arkitekt Åke E Lindqvist och användes som skola mellan åren 1952-1992 och byggdes sedan om till bostäder 1999.\r\nPerfekt beläget i ett lugnt område mellan Årsta Torg och Årstaberg med goda kommunikationer som pendeltåg, tvärbana och bussar. Busshållplats utanför porten. Närhet till Årstaviken som erbjuder löpspår, utegym och härliga skogspromenader. Som närmsta granne finns vackra storängsparken med härliga grönytor och lekplatser. På 10 minuter tar ni er enkelt till Södermalm med fina cykelvägar.", 40, 5267m, 2, 1, 0, "87efc5ac-77d8-4729-b3d6-3309dc88e88d", 0, 0, 1952, 0m },
                    { 3, "Vinkelhuset", 15300000m, "Stor balkong med utsikt över Mälarens glittrande vatten. Våningen erbjuder generösa sällskapsytor som är i öppen planlösning med köket. Den flexibla planlösningen ger möjlighet till upp till fyra sovrum, där en del kan göras om till en separat avdelning, perfekt som kontor eller för uthyrning.\r\n\r\n\r\n\r\nKöket är från Kvänum med köksluckor och hyllor är i ek hazel, med bänkskiva och stänkskydd i Thala Grey kalksten. Helintegrerad kyl, frys och diskmaskin samt induktionshäll med integrerad fläkt och varmluftsugn. Alla vitvaror från Miele. Väggarna i duschutrymmet och klinker på golvet är i Bricmate Rune Light Grey. Lådor är i valnöt från Haven, handfatet är i kvartskomposit och blandaren från Tapwell. All förvaring är från WL Systems.\r\n\r\n\r\n\r\nEtt sofistikerat och tidlöst boende. Genom att se bortom invanda mönster utvecklar vi vackra, genomtänkta och personliga hem. Hem som du kan leva i och beröras av länge.", 158, 8996m, 2, 5, 0, "87efc5ac-77d8-4729-b3d6-3309dc88e88d", 0, 0, 2025, 24540m },
                    { 4, "Frida Åslunds gränd 1C", 1995000m, "Välkommen till denna ljusa och fina tvåa på Sandåkern närmast Tvärån. Lägenheten är mycket välplanerad och flödar av ljus via stora fönster med fin utsikt från vardagsrum, kök, sovrum och badrum. Inglasad balkong som vetter mot innergård, med sol fram till cirka klockan tre. Lägenheten har en vacker omgivning är granne med Tvärån. Promenadavstånd till centrum, affär, fina promenadstråk och strandpromenaden. Busshållplats finns nära bostaden.", 62, 4489m, 1, 2, 0, "26f1c93b-0ce3-4655-a0e1-f0d91dbe6c71", 0, 0, 1901, 3600m },
                    { 5, "Svajetvägen 40", 2995000m, "Välkommen till detta utbyggda och renoverade sommarparadis beläget på mycket attraktivt läge. Den vackra utsikten över havet är slående oavsett om du befinner dig utomhus eller kliver in i stugans stilrena och vilsamma miljö. Stugan är utbyggd och smakfullt renoverad och håller en hög standard där de sociala ytorna är generösa och mycket tilltalande. Kök, matplats och vardagsrum integrerar i öppen planlösning med havet i ständigt blickfång genom stora fönsterpartier som verkligen sätter prägel på ditt boende. En öppen spis ger extra mysfaktor. Utöver de sociala ytorna disponeras två sovrum samt ett rymligt badrum med tvättstuga. På tomten finns även två renoverade gäststugor och ett intilliggande förråd. En rymlig altan länkar samman flera av byggnaderna samt erbjuder flera solfyllda uteplatser med utrymme för exempelvis utekök, loungedel, matplats och solplats. Med andra ord finns gott om utrymme för familj och vänner att rymmas och för dig bara att flytta in och njuta av ditt nya sommarparadis! Möjlighet till snabbt tillträde! \r\nNedanför stugan når du en mindre sandstrand och inte långt bort ligger den mysiga stranden vid Karthällan. Närheten till havet innebär aktiviteter i princip året runt! Sommartid kan du bada, göra utflykter med cykel och båt eller varför inte bara ströva i skogen för svamp-bärplockning. När isen lagt sig kan du åka skridskor, skidor och skoter. Här finns också möjlighet till fiske. Sörmjöle är ett populärt sommar- och åretruntboende med bra pendlingsavstånd till Umeå.", 81, 0m, 1, 3, 1938, "26f1c93b-0ce3-4655-a0e1-f0d91dbe6c71", 0, 3, 1963, 21597m },
                    { 6, "Tallparksvägen 17A", 2195000m, "Välkommen till denna  4:a på eftertraktad adress på Grisbacka, med ett kanonläge och en inglasad balkong i söder. Denna lägenhet erbjuder rymliga rum med en praktisk planlösning som passar perfekt för familjen. Det trivsamma köket har en matplats som inbjuder till trevliga måltider, medan det stora och luftiga vardagsrummet ger gott om utrymme för avkoppling och sociala stunder.\r\nDen inglasade balkongen i söderläge är perfekt för att njuta av soliga dagar. Bostaden har också ett duschrum med tvättmaskin, en separat gäst-WC och ett rymligt master-bedroom. De två multifunktionella extrarummen kan enkelt anpassas till barnrum, kontor eller gästrum, beroende på dina behov.\r\nLägenheten ligger i en välskött förening med en stor och trivsam innergård där barnen kan leka på lekplatsen. På Tallparksvägen bor du i ett lugnt och omtyckt område, perfekt perfekt för dig som värdesätter närhet till centrum, mataffärer, motionsspår och skolor. Goda kommunikationer finns till både universitetet och NUS, vilket gör lägenheten perfekt för pendling.\r\nMissa inte chansen att uppleva denna bostad – boka din visning idag!\r\nVarmt välkommen!", 97, 6239m, 1, 4, 0, "26f1c93b-0ce3-4655-a0e1-f0d91dbe6c71", 0, 0, 1964, 22629m },
                    { 7, "Björkgatan 11", 1675000m, "Med sin vackra tegelstensfasad och genomtänkta planlösning erbjuder detta 1 ½-planshus en perfekt kombination av komfort och funktionalitet. Här finns hela 141 kvm boyta och 56 kvm biarea, fördelat på fem rymliga sovrum vilket gör det till ett utmärkt hem för den stora familjen.\r\nTomten på 981 kvm är lummig och välskött med gräsmatta, träd och buskar, och den härliga uteplatsen i söderläge bjuder in till avkopplande stunder i solen. Huset har dessutom bergvärme, vilket ger energieffektiv uppvärmning året runt.  Ny bergvärmepump installerad april 2025, komplett med garantier.\r\nFör dig som behöver gott om förvaringsutrymmen finns både ett varmförråd på garagevinden och ett praktiskt varmgarage. Läget är optimalt – centralt i Bureå men på en lugn gata, precis intill skola, förskola, simhall, hockeyplan, fotbollsplan, elljusspår och skog, vilket gör vardagen smidig och bekväm.\r\nHuset är besiktat och Varudeklarerad inför försäljning för din trygghet. Missa inte chansen att skapa ditt drömhem här – varmt välkommen att boka visning!", 141, 0m, 9, 6, 981, "26f1c93b-0ce3-4655-a0e1-f0d91dbe6c71", 56, 2, 1962, 38256m },
                    { 8, "Boviksbadet 408", 4500000m, "Här på Boviksbadet 408, endast 15 minuter från stan, väntar ett inflyttningsklart drömboende med egen pool, gästhus och stora uteplatser som bjuder in till soliga dagar och ljumma kvällar.\r\nStarta morgonen med ett dopp i poolen, spendera dagen på någon av de vackra badstränderna och avsluta med en grillmiddag medan solen sänker sig bakom trädtopparna. Här är det lätt att koppla av och njuta av sommarens bästa stunder!\r\nDet stilfulla fritidshuset har genomgått en omfattande renovering och erbjuder en perfekt mix av modern komfort och somrig charm. Här möts du av en ljus och fräsch interiör med nytt kök från 2023, generösa sällskapsytor och tre sovrum, vilket gör det enkelt att umgås med familj och vänner.\r\nUteplatsen är en riktig oas skapad för njutning och avkoppling. Den nyrenoverade poolen (2024) med nytt pooltäcke och egen luftvärmepump blir snabbt den naturliga samlingspunkten för hela familjen.\r\nRunt poolen finns stora soldäck och uteplatser, perfekta för lata dagar i solen eller härliga grillkvällar med nära och kära. Gäststugan och den mindre jadestugan ger gott om plats för övernattande gäster och skapar en exklusiv känsla av en privat semesteranläggning.\r\nEldstaden skapar en mysig atmosfär under svalare kvällar, och med fiberanslutning kan du enkelt jobba på distans eller streama sommarens favoriter.\r\nLäget är oslagbart! Med promenadavstånd till badstränder, en populär camping med sommarrestaurang och natursköna omgivningar finns alla förutsättningar för en perfekt sommar. Här får du det bästa av två världar – total avkoppling vid havet och närhet till stadens bekvämligheter.\r\nDetta är inte bara en sommarstuga – det är en livsstil! Ett nyckelfärdigt sommarboende i toppskick, där du kan njuta från första stund. Missa inte chansen att göra detta till din egen sommaridyll – välkommen att boka visning!", 135, 0m, 9, 3, 1647, "26f1c93b-0ce3-4655-a0e1-f0d91dbe6c71", 0, 3, 1960, 52093m },
                    { 9, "Styrmansgatan 23", 2650000m, "Här bor du i en smakfullt renoverad fastighet där den klassiska 30-talskaraktären möter modern funktionalitet.\r\nHuset ligger på ett bekvämt avstånd från allt du behöver – bara 200 meter till mataffär och bussförbindelser samt 100 meter till närmaste lekpark, vilket ger en perfekt balans mellan lugn och närhet till service. Här har du en fin utsikt över Ursviksfjärden från husets kök, badrum, sovrum och balkong.\r\nHuset har genomgått flera uppdateringar, bland annat ett nyrenoverat tak (2023), kök (2020), badrum (2025) och fjärrvärme. Allt detta kombineras med en härlig atmosfär och gedigna materialval.\r\nNär du kliver in i entrén möts du av en välkomnande yta för avhängning. Härifrån fortsätter du vidare in i det rymliga vardagsrummet, där de tidstypiska pardörrarna ger en känsla av elegans och charm.\r\nKöket är öppet mot matrummet och erbjuder en praktisk lösning med en stor flyttbar köksö, perfekt för stora middagar och familjesammankomster. Från matplatsen når du den soliga, stora verandan som har rymt upp till 20 sittplatser. Verandan vetter åt väster, vilket ger dig sol från lunch till resten av kvällen.\r\nTakhöjden på entréplanet når ca 3 meter, vilket tillsammans med tidstypiska detaljer så som en eldningsbar järnspis, gör att du lätt kan känna historiens vingslag.\r\nPå övre plan finns tre bra sovrum varav ett med en vacker eldningsbar kakelugn. Ett nyrenoverat badrum samt även ett allrum som är perfekt för avkoppling och mysiga stunder framför braskaminen. En trappa leder upp till den oinredda vinden, som erbjuder möjlighet att skapa mer yta efter behov.\r\nUte finns en underbar uppvuxen trädgårdstomt med fruktträd, hallonbuskar och rabarber – en perfekt plats för både odling och avkoppling. Mellan garage och veranda är det stenlagt, och på uppfarten finns gott om plats. Ett stort varmbonat dubbelgarage på ca 56 m² erbjuder bra utrymme för hobbys och förvaring.\r\nKällaren har förutom en trappa ner även en separat ingång och rymmer matkällare och tvättstuga samt ett ombonat rum, perfekt som tonårsrum eller gästrum. Här kan du verkligen få plats med hela familjen och deras behov.\r\nStyrmansgatan 23 är en unik möjlighet för dig som söker ett hus med både karaktär, funktion samt garage – Varmt välkommen att boka visning på vår hemsida!", 145, 0m, 9, 6, 1160, "26f1c93b-0ce3-4655-a0e1-f0d91dbe6c71", 48, 2, 1926, 58054m },
                    { 10, "Åkerviksvägen 24", 1200000m, "Välkommen till Åkerviksvägen 24 i charmiga Botsmark – en friliggande villa som erbjuder en perfekt kombination av rymlighet och naturnära boende. Med en boyta på 134 m² och en biyta på 101 m² fördelat på 5 rum, varav 3 sovrum, finns här gott om plats för hela familjen. Tomten på 1 136 m² är uppvuxen och erbjuder ett öppet och fritt läge, perfekt för trädgårdsentusiasten eller för barnens lek.?\r\nDenna 1½-plansvilla med källare är byggd för att möta behoven hos en växande familj eller för dig som söker extra utrymme för hobbyverksamhet eller hemmakontor. Botsmark erbjuder en lugn och trivsam miljö med närhet till naturen, samtidigt som Umeås stadskärna nås inom rimligt avstånd för arbete och nöjen.\r\nBotsmark präglas av en stark gemenskap och arrangerar årligen Botsmarksdagen, en dag fylld med marknadsstånd, hantverk, lotterier och barnaktiviteter. Detta evenemang, vanligtvis i augusti, är ett utmärkt tillfälle att uppleva den lokala kulturen och träffa byborna.\r\nOavsett årstid finns det aktiviteter att utforska. Vintertid kan du njuta av skoteråkning, skidåkning och pulkaåkning, medan sommaren bjuder på bad i insjöar, vandringar och möjligheter till olika bollsporter på de öppna ängarna.\r\nSammanfattningsvis erbjuder Botsmark en harmonisk blandning av naturskönhet, kulturella evenemang och fritidsaktiviteter, vilket gör det till en attraktiv plats för både boende och besökare som söker en lugn och aktiv livsstil.\r\nFör den naturintresserade finns Västermarks naturreservat några kilometer från Botsmark. Här kan du vandra eller åka skidor längs markerade leder.\r\nEn annan sevärdhet är världens största flyttblock och grottor i närheten av Botsmark, vilket gör området till ett spännande utflyktsmål för familjer och äventyrslystna.\r\nTa chansen att förvärva denna pärla i hjärtat av Västerbotten!", 134, 0m, 1, 5, 1136, "26f1c93b-0ce3-4655-a0e1-f0d91dbe6c71", 101, 2, 1971, 46585m },
                    { 11, "Kemigränd 29", 1190000m, "Tvåa centralt i studentstaden Umeå. Passar student då det är nära till både universitetssjukhuset och universitetet. Dessutom finns Ålidhem centrum med dess restauranger, mataffärer och serviceutbud inom gångavstånd. För dig som gillar mysiga promenader finns Ålidparken.\r\nBostaden är bra planerad och erbjuder ett rymligt vardagsrum, kök med separat matplats, ett sovrum samt badrum med tvättmaskin. Till bostadsrätten hör ett förråd som är beläget på samma våningsplan. Väldigt praktiskt när saker ska hämtas och lämnas.\r\nEnligt föreningen är ekonomin stabil. Föreningen tillhandahåller välvårdad gemensam innergård för de boende i huset. Här finns sittmöbler och grillplats. Parkeringsplats och varmgarage kan hyras enligt separat kö via föreningen.\r\nVälkommen på visning!", 63, 4024m, 1, 2, 0, "26f1c93b-0ce3-4655-a0e1-f0d91dbe6c71", 0, 0, 1970, 5616m },
                    { 12, "Yrkesgatan 46", 1295000m, "Välkommen till denna trevliga 2:a på våning 2 i Brf Stålet. Bostaden har ett ljust kök med både bra förvaring och arbetsytor samt full maskinell utrustning. I köket finns plats för mindre matgrupp invid fönster. Öppningen in mot vardagsrummet bidrar till den ljusa och öppna känslan. I det luftiga vardagsrummet finns plats för både soffgrupp och större matgrupp. Här nås även den trivsamma balkongen. Sovrummet är rymligt och inrymmer dubbelsäng med lätthet, här finns både förvaring via garderober samt klädkammare i anslutning. Badrum med våtrumsmatta på väggar och golv, samt en rymlig hall med goda möjligheter för avhängning och ytterligare möjlighet för förvaring om så önskas. \r\n\r\n\r\n\r\nI källaren finns ett mindre förråd samt ett större förråd att disponera, i det större förrådet finns praktiskt en klädvårdsavdelning med tvättmaskin och torktumlare samt förvaringsmöjligheter längs ena väggen. Till lägenheten hör också en motorvärmarplats belägen direkt invid huset. Garageplatser finns i föreningen och dessa fördelas enligt separat kö. \r\n\r\n\r\n\r\nBrf Stålet är en förening om 120 lägenheter fördelat på 30 huskroppar. I månadsavgiften ingår värme, vatten, kabel-tv, bredband, fast kostnad för IP-telefoni, motorvärmarplats samt bostadsrättstillägg till hemförsäkringen. Föreningen tillämpar enhetsmätning av elen vilket innebär att lägenhetsinnehavaren endast betalar för den förbrukade elen och föreningen står för de fasta kostnaderna. Skurholmen är ett populärt bostadsområde med blandade boendeformer. Goda bussförbindelser till både centrum, Luleå Tekniska Universitet och Sunderby Sjukhus. Närhet till matvarubutik, apotek och restauranger.", 60, 4660m, 3, 2, 0, "26f1c93b-0ce3-4655-a0e1-f0d91dbe6c71", 0, 0, 1947, 972m },
                    { 13, "Nygatan 6F", 1595000m, "Bo högt upp mitt i city – en modern och smakfull välrenoverad pärla!\r\nVälkommen till en superfin och inflyttningsklar lägenhet där modern stil och funktion möts på ett fantastiskt sätt! Här bor du på ett svårslaget läge, med stadens puls precis runt hörnet. Lägenheten har genomgått en smakfull renovering 2022 och erbjuder ett rymligt och elegant kök, ett helkaklat badrum i toppskick samt ett ljust och inbjudande vardagsrum med charmigt burspråk och utgång till balkong. Stabil förening och en bostad där du bara kan flytta in och börja trivas från dag ett.\r\nKontakta mäklaren för mer information eller för att boka in en förhandsvisning!", 59, 3449m, 10, 2, 0, "26f1c93b-0ce3-4655-a0e1-f0d91dbe6c71", 0, 0, 1962, 4260m },
                    { 14, "Aspnäsvägen 12", 6150000m, "Välplanerad 4:a med radhuskänsla belägen på den lummiga delen av Näset, återvändsgatan Aspnäsvägen. 88 välplanerade kvm i genomgående bra skick med öppen planlösning, tre bra sovrum och två badrum samt en stor uteplats i sydvästligt läge gör detta till ett perfekt substitut för radhus. Förråd på samma våningsplan vilket är smidigt. Välskött förening med god ekonomi. Näset är ett populärt område på Lidingö med både centralt och lugnt läge. Här bor du nära både natur och grönområden med fina promenadstråk samtidigt om du bara har ca 8 minuter till Ropsten med buss. För dig som gillar att cykla finns bra cykelvägar. På Källängstorget finns matbutik och restaurang. Välkommen att kontakta ansvarig mäklare för mer information!", 88, 6685m, 2, 4, 0, "a64ba80d-139c-4816-a169-9344e3d58e22", 0, 0, 1964, 16622m },
                    { 15, "Pastellvägen 30", 2995000m, "Välkommen till denna ljusa och insynsskyddade gavelbostad på eftertraktade Pastellvägen. Med fönster i tre väderstreck flödar naturligt ljus in från morgon till kväll, vilket skapar en luftig och trivsam atmosfär. Rymligt vardagsrum med stora fönster som bjuder på härlig utsikt och vackert ljusinsläpp. Trevligt fullutrustat kök med gott om utrymme för matlagning och matplats. Goda förvaringsmöjligheter i lägenheten samt ett källarförråd. \r\nHär bor du med ett fantastiskt läge i härliga och attraktiva Johanneshov som erbjuder grönskande parker och bra restauranger och fik. Gamla Enskede Matbod, Robin Delselius bageri och Matateljén är bara några exempel. På 3 minuter kommer du till Blåsut där T-banan tar dig in till Söder på endast 6 min. Här finns även bra cykelvägar som tar dig in på 10 minuter. I Sandsborg finns ICA Supermarket, apotek och Sandsborgsbadet. Inom räckhåll har du även Globenområdet där det finns gott om shopping, restauranger och matbutiker. I närheten finns 3 arena och Hovet som erbjuder många spännande evenemang.", 57, 4168m, 2, 3, 0, "a64ba80d-139c-4816-a169-9344e3d58e22", 0, 0, 1943, 52544m },
                    { 16, "Skvadronvägen 60 B", 5995000m, "Välkommen till denna exklusiva bostadsrätt i Brf Skvadronhöjden, belägen i det populära området Tingvalla i Vallentuna. Med en boyta på 124 kvadratmeter och fem rum erbjuder detta hem generösa ytor för hela familjen att trivas i.\r\nDet som verkligen utmärker denna bostad är dess unika fördelar som takterass, bastu samt uppvuxen välskött trädgård med uteplats. På takterassen kan du njuta av solens strålar och vid den uppvuxna trädgården kan du koppla av i en fridfull miljö. Med en uteplats för trevliga middagar och sociala stunder utomhus får du en perfekt plats att umgås och skapa minnen tillsammans. Bastu finns i bostaden och parkering och förråd ingår också.\r\nOmrådet Tingvalla erbjuder lugn och ro samtidigt som det har gott om bekvämligheter inom räckhåll. Här finns närhet till skolor, service och grönområden för avkoppling och rekreation.\r\nDenna bostadsrätt är inte bara ett hem, det är en investering i livskvalitet och gemenskap. Passa på att ta chansen att bli en del av detta harmoniska bostadsområde i Vallentuna. Kontakta oss för visning och upplev allt detta hem har att erbjuda!", 124, 7942m, 2, 6, 0, "b03b6b66-a5fd-4fbc-a3f2-9c7202cbee60", 7, 1, 2019, 18391m },
                    { 17, " Vallhöjdsvägen 19", 2895000m, "Välkommen till Vallhöjdsvägen 19 i det natursköna området Kallfors, Järna. Denna moderna bostadsrätt från 2022 erbjuder 75 kvm boyta fördelat på 3 rum och kök, allt i nyskick. Belägen på bottenvåningen med en generös balkong om 20 kvm, får du här ett boende som kombinerar komfort med stil. Välkomna på visning av er nya bostad!", 75, 6131m, 2, 3, 0, "b03b6b66-a5fd-4fbc-a3f2-9c7202cbee60", 0, 0, 2022, 8088m },
                    { 18, "Abborrens väg 4", 3500000m, "I populära Vätö (Klockarängen) ligger denna soliga och välskötta fastighet på hörntomt utan insyn!\r\nVälkommen till ett drömlikt boende med huvudbyggnad från 2013, stort gästhus med flertalet bäddar samt med naturen som granne.\r\nHär bor ni skärgårdsnära med närhet till havsbad på fin strand, möjlighet till båtplats samt vackra strövområden och vandringsleder i fantastiska omgivningar.\r\nDetta lyxiga fritidshus lämpar sig väl även som permanentboende med ett hus om ca. 71 kvm (Entréplan) samt ett stort allrum på övre plan.\r\nHuvudbyggnaden erbjuder två stora sovrum, vardagsrum/kök i öppen planlösning med värmande täljstenskamin. Köket är bra utrustat med t.ex. diskmaskin och plats för köksbord åt 8 personer. Från kök/vardagsrum finns dörr ut till stora altanen. Badrummet erbjuder dusch, snålspolande vattentoalett, tvättmaskin och bastu.\r\nUtöver huvudbyggnad finns ett gästhus, om ca. 42 kvm. Här finns vardagsrum, litet kök, sovrum samt ett toalettrum.\r\nUtöver detta finns två friggebodar om ca. 10 kvm & 12kvm.\r\nHörntomten om 2 308 kvm ligger insynsskyddat har en härlig mix av trädgård- och naturtomt med berg i dagen. Trädgården klarar sig till stor del på egen hand och är välplanerad med gräsytor, planteringar och blommor. De intilliggande skogarna erbjuder gott om svamp och bär precis som på denna tomt. Favoritplatsen är helt klart den trädäckade altan på berget med paviljong och växthus!\r\nFastigheten har tillgång till vatten året runt in till huvudbyggnad via egen borrad brunn samt är kopplad till godkända avlopp. Man har också tillgång till sommarvatten via samfällighetsförening. Här finns också fiber som möjliggör distansarbete likväl som tonåringars spellystnad.\r\nDet har gjorts ett flertal stora renoveringar under de senaste åren. Se längre ner i annonsen för mer information om dessa renoveringar. Här kan man verkligen koppla av från dag 1 då allt är välskött, renoverat och i bra skick!\r\nDetta boende erbjuder aktiviteter året om när årstiderna skiftar. Bad om sommaren sker på badstranden i området som också har ett hopptorn. Vid badstranden har man också möjlighet till båtplats på välskötta båtbryggor. Ni har närhet till områdets välskötta grönområden med bl.a. fotbollsplan för lek och spel samt boulebana. I Harg finns det matbutik, skola och dagis och i Nysättra strax före Vätöbron finns bygghandel, pizzeria och kiosk. Ni har 14 km till Roslagens golfbana där det på vintertid finns en slinga på 7 km för skidor. 3,5 km till populära Vätö självplock och färska jordgubbar. Ni har 85 km med bil till Stockholm och 20 km till Norrtälje. Roslagen har ett fint vägnät för landsvägscykling. Fastigheten ligger med närhet till bondgård med möjlighet till hästridningslektioner.\r\nNi har 300 m till närmaste busshållplats (buss nr 638) som tar dig direkt in till Norrtälje på 55 minuter.\r\nVälkommen med din visningsanmälan!", 71, 0m, 2, 3, 2308, "91858c77-9f96-4e67-8b4d-12065003247a", 28, 3, 2013, 49442m },
                    { 19, "Agatvägen 28", 1495000m, "Kontakta mäklaren för privatvisning!\r\nVälkommen till denna fantastiskt charmiga och välplanerade lägenhet, belägen i ett vackert 30-talshus med bevarade originaldetaljer. Här möts du av stora spröjsade fönster med djupa nischer, generös takhöjd och en genomtänkt planlösning som gör bostaden perfekt för både singelhushållet och paret. Bostaden ligger i hjärtat av idylliska Beckomberga och präglas av ett härligt ljusinsläpp från tre stora fönster i fil. Här bor du i en stabil och välskött förening där både bredband och TV ingår i månadsavgiften. Dessutom erbjuds gratis parkering inom föreningen – en sällsynt förmån i Stockholm! Fastigheten genomgick en omfattande renovering mellan 2002–2004, inklusive stambyte.\r\nEtt område med närhet till allt. Beckomberga har de senaste åren vuxit fram som ett av Brommas mest eftertraktade bostadsområden. Här trivs du som söker lugn och grönska, samtidigt som du har smidig access till city – endast 15 minuter bort. Området erbjuder ett stort utbud av förskolor och skolor, däribland Beckombergaskolan, Raoul Wallenbergs skola och Kastanjelundens förskola. Kommunikationerna är utmärkta med buss 117, som tar dig till Brommaplan på 5–7 minuter, samt närhet till både Spånga station och tunnelbanans gröna linje vid Islandstorget och Råcksta.\r\nI området finns två välsorterade matbutiker och flera omtyckta restauranger och caféer, såsom Café Blå Koppen, Bromma Bistro och Arigato Sushi. För den träningsintresserade finns gymmet Puls & Träning, simhall och sporthall i närheten, samt fina promenadstråk för avkopplande stunder i naturen.", 35, 4711m, 2, 1, 0, "91858c77-9f96-4e67-8b4d-12065003247a", 0, 0, 1929, 42714m },
                    { 20, "Bagarstugans väg 42", 5495000m, "\"Området är som en oas med kort gångavstånd till Stockholms bästa brunch på Stenladan, en perfekt strand finns i närheten för att doppa sig dem varma dagarna. Vi har speciellt uppskattat naturen med flertalet vandringsstigar, grönska och djurliv. Utöver det kommer marinan strax vara färdigrenoverad, skola samt förskola byggd samt stallet fyllas med olika hästar.\"\r\nVälkommen till detta vackert designade friköpta parhus med oslagbart läge i Steninge Slottsby! Materialvalen följer som en röd tråd genom hela bostaden och färgnyanserna kopplar ann till naturen runtomkring. Här bor du med naturen som närmsta granne och all bekvämlighet en familj kan tänka sig. Tack vare gavelläget har du mer ljusinsläpp och ett friare läge i området. Huset som stod färdigt 2023 är en del av bostadskvarteret Solfjädern med totalt tio unika parhus om 124 kvadratmeter med 5 rum och kök ritade av arkitekterna på Blooc. Fastigheten kommer att anslutas till en samfällighet för skötsel av vägar och gemensamma ytor i området. Att bo i Steninge Slottsby är förenat med livskvalitet och hela området är omgivet av natur.", 124, 0m, 2, 5, 382, "e7cde164-d981-41df-b3d9-35d42c0d8323", 0, 1, 2022, 30905m }
                });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "Id", "ImageUrl", "PropertyForSaleId" },
                values: new object[,]
                {
                    { 1, "https://bilder.hemnet.se/images/itemgallery_cut/ac/f1/acf19745115e18c49dd040a84fd2660f.jpg", 1 },
                    { 2, "https://bilder.hemnet.se/images/itemgallery_cut/be/88/be88d78da8f65c5d303b25fbbe5fed59.jpg", 1 },
                    { 3, "https://bilder.hemnet.se/images/itemgallery_cut/90/d6/90d6a28ed3f53038d2e0499ebe3fd507.jpg", 1 },
                    { 4, "https://bilder.hemnet.se/images/itemgallery_cut/76/d8/76d8499e86ab1edd3ec980aa0bc0f942.jpg", 2 },
                    { 5, "https://bilder.hemnet.se/images/itemgallery_cut/eb/c5/ebc54c89f9033d97441574682cc0f9c9.jpg", 2 },
                    { 6, "https://bilder.hemnet.se/images/itemgallery_cut/e4/f5/e4f5ab0a2cddda36e2da1c37088e24ed.jpg", 2 },
                    { 7, "https://bilder.hemnet.se/images/itemgallery_portrait_cut/ca/1a/ca1a194c4f3c7cca07779fb2f6d2644d.jpg", 3 },
                    { 8, "https://bilder.hemnet.se/images/itemgallery_cut/f7/89/f789ec3ba16848378f6328221121b057.jpg", 3 },
                    { 9, "https://bilder.hemnet.se/images/itemgallery_cut/9a/cb/9acb29ab2314046532f9da526346a139.jpg", 3 },
                    { 10, "https://bilder.hemnet.se/images/itemgallery_cut/79/b8/79b8792c8f4743428608e021b85494b9.jpg", 4 },
                    { 11, "https://bilder.hemnet.se/images/itemgallery_cut/3f/9b/3f9b421dcd930576e05925c7b9ed60a1.jpg", 4 },
                    { 12, "https://bilder.hemnet.se/images/itemgallery_cut/92/ea/92ea89763a4237a6637df15827c04e4a.jpg", 4 },
                    { 13, "https://bilder.hemnet.se/images/itemgallery_cut/d8/54/d8543df8138af90c3dc5ea3cf32dc9da.jpg", 5 },
                    { 14, "https://bilder.hemnet.se/images/itemgallery_cut/70/6c/706c97ac19cac789e2f98c8eecb4ec71.jpg", 5 },
                    { 15, "https://bilder.hemnet.se/images/itemgallery_cut/0f/93/0f937c2e81d4a1845ff48840c62ff6a8.jpg", 5 },
                    { 16, "https://bilder.hemnet.se/images/itemgallery_cut/7a/21/7a2141072e9c0bc28be6c3d6da5100d5.jpg", 6 },
                    { 17, "https://bilder.hemnet.se/images/itemgallery_cut/51/bb/51bb7288f7dcde60e2eb41a5d1fd45cd.jpg", 6 },
                    { 18, "https://bilder.hemnet.se/images/itemgallery_cut/fb/3a/fb3ae2895049eca7f9c16503b05cab40.jpg", 6 },
                    { 19, "https://bilder.hemnet.se/images/itemgallery_cut/d4/f0/d4f0beabcd7b18c96976129e0202560c.jpg", 7 },
                    { 20, "https://bilder.hemnet.se/images/itemgallery_cut/0f/04/0f042421d788be5425596da917424a4f.jpg", 7 },
                    { 21, "https://bilder.hemnet.se/images/itemgallery_cut/88/b0/88b0101d3fb67669270c5e8e4e9cd5ac.jpg", 7 },
                    { 22, "https://bilder.hemnet.se/images/itemgallery_cut/65/49/65490afef2a1308ae71f6673c7c2c4fb.jpg", 8 },
                    { 23, "https://bilder.hemnet.se/images/itemgallery_cut/e4/c4/e4c4fca9793d5b24f7f18ee3dacbc36b.jpg", 8 },
                    { 24, "https://bilder.hemnet.se/images/itemgallery_cut/f8/c3/f8c3facbae57fc8cf7f968353ccfad78.jpg", 8 },
                    { 25, "https://bilder.hemnet.se/images/itemgallery_cut/30/6c/306c3ea99e55271e62fbd6929ad0aa7a.jpg", 9 },
                    { 26, "https://bilder.hemnet.se/images/itemgallery_cut/5a/b6/5ab6d27904bc611421f86acca1ccc3b0.jpg", 9 },
                    { 27, "https://bilder.hemnet.se/images/itemgallery_cut/ce/11/ce11059233c17cf7f87566b8b487ddc5.jpg", 9 },
                    { 28, "https://bilder.hemnet.se/images/itemgallery_cut/e5/85/e585c94e8d02a3ab282efeae0aeb3159.jpg", 10 },
                    { 29, "https://bilder.hemnet.se/images/itemgallery_cut/aa/89/aa893560dccd876332d790c30f21a09f.jpg", 10 },
                    { 30, "https://bilder.hemnet.se/images/itemgallery_cut/8d/4b/8d4bcd3ee51bb7094132be5213b5a176.jpg", 10 },
                    { 31, "https://bilder.hemnet.se/images/itemgallery_cut/40/de/40de5d03dd09bf4080d38a27ee31879d.jpg", 11 },
                    { 32, "https://bilder.hemnet.se/images/itemgallery_cut/4f/b2/4fb28af61b62ebfbf80d29cfdea47f04.jpg", 11 },
                    { 33, "https://bilder.hemnet.se/images/itemgallery_cut/25/e5/25e59549eea6a523d399a450bedad7e8.jpg", 11 },
                    { 34, "https://bilder.hemnet.se/images/itemgallery_cut/ba/51/ba511339c135aff60088ff6d75b0981d.jpg", 12 },
                    { 35, "https://bilder.hemnet.se/images/itemgallery_cut/b2/db/b2dbaff689d60fcfe298217ba59bbb71.jpg", 12 },
                    { 36, "https://bilder.hemnet.se/images/itemgallery_cut/43/ef/43ef83bc0e71166110bb5ab84ce7bcb3.jpg", 12 },
                    { 37, "https://bilder.hemnet.se/images/itemgallery_cut/13/03/1303775a9171feca8e4266b0da7f6054.jpg", 14 },
                    { 38, "https://bilder.hemnet.se/images/itemgallery_cut/c4/62/c4629aa02aad6cee752eba7b14139a18.jpg", 14 },
                    { 39, "https://bilder.hemnet.se/images/itemgallery_cut/57/cd/57cdc04e183c17865e8439501d59e349.jpg", 14 },
                    { 40, "https://bilder.hemnet.se/images/itemgallery_cut/76/a5/76a52eda3d1e7f0c3891b7802dede629.jpg", 15 },
                    { 41, "https://bilder.hemnet.se/images/itemgallery_cut/b4/2f/b42f543bd3090d6464f5d6d9805cbd30.jpg", 15 },
                    { 42, "https://bilder.hemnet.se/images/itemgallery_cut/5e/6e/5e6eb2f48b3d357bc924216a54f40852.jpg", 15 },
                    { 43, "https://bilder.hemnet.se/images/itemgallery_cut/c3/35/c3356a1e426db8537a6e045923f8e02c.jpg", 16 },
                    { 44, "https://bilder.hemnet.se/images/1024x/49/02/49020ae6b62d49631fc776916ec6abf7.jpg", 16 },
                    { 45, "https://bilder.hemnet.se/images/1024x/a1/54/a1540769cb5417df8be54afd0bcc0dd9.jpg", 16 },
                    { 46, "https://bilder.hemnet.se/images/itemgallery_cut/e2/00/e200c574a8de09cf1f97764b6b0dd130.jpg", 17 },
                    { 47, "https://bilder.hemnet.se/images/itemgallery_cut/07/02/07029e6ddb26229039ddd5fa76fb5b8c.jpg", 17 },
                    { 48, "https://bilder.hemnet.se/images/itemgallery_cut/88/7a/887a4bc0e4350a475fd39c0bac683c71.jpg", 17 },
                    { 49, "https://bilder.hemnet.se/images/itemgallery_cut/6a/09/6a0987081cf8d42daf6a7b21293a4d01.jpg", 18 },
                    { 50, "https://bilder.hemnet.se/images/itemgallery_cut/9e/c3/9ec34914afb3f69e278118a9e4e3f105.jpg", 18 },
                    { 51, "https://bilder.hemnet.se/images/itemgallery_cut/cc/9c/cc9c15a1c520fa3483d757fe2e87ec9e.jpg", 18 },
                    { 52, "https://bilder.hemnet.se/images/itemgallery_cut/3a/a1/3aa161c5fbf2c195c02e969d3c08f8a9.jpg", 19 },
                    { 53, "https://bilder.hemnet.se/images/itemgallery_cut/17/c5/17c512c4f0b77ddcc469c177ccc507f6.jpg", 19 },
                    { 54, "https://bilder.hemnet.se/images/itemgallery_cut/33/c7/33c7cd2dffcc5fe265bee1b2582b12bb.jpg", 19 },
                    { 55, "https://bilder.hemnet.se/images/itemgallery_cut/90/9b/909bb173777f51d64bc2e01f310a8b1a.jpg", 20 },
                    { 56, "https://bilder.hemnet.se/images/1024x/1f/c3/1fc3e10be0368d95cfb8d43c7aae611a.jpg", 20 },
                    { 57, "https://bilder.hemnet.se/images/1024x/17/90/17901d6115000babb80df084b149e615.jpg", 20 },
                    { 58, "https://bilder.hemnet.se/images/itemgallery_cut/c5/86/c58676cf3ebdf4e13163289ff20275e8.jpg", 13 },
                    { 59, "https://bilder.hemnet.se/images/itemgallery_cut/c4/26/c426696d7ebd9c382c7754d55324411b.jpg", 13 },
                    { 60, "https://bilder.hemnet.se/images/itemgallery_cut/87/cc/87cce528941e3728d37489276de08a97.jpg", 13 }
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
