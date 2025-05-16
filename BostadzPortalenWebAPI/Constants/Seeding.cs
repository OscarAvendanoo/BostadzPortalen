using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
//Author: Johan Nelin

namespace BostadzPortalenWebAPI.Constants
{
    public static class Seeding
    {
        public static ModelBuilder IdentityRolesBuilder(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER",
                    Id = SeedGUID.RoleUser
                },
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    Id = SeedGUID.RoleAdmin
                },
                new IdentityRole
                {
                    Name = "Realtor",
                    NormalizedName = "REALTOR",
                    Id = SeedGUID.RoleRealtor
                }
            );
            return builder;
        }

        public static ModelBuilder RealEstateAgencyBuilder(ModelBuilder builder)
        {
            builder.Entity<RealEstateAgency>(t =>
            {
                t.HasData(
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 1,
                        AgencyName = "ADMIN ONLY",
                        AgencyDescription = "Admin Agency",
                        AgencyLogoUrl = ""
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 2,
                        AgencyName = "Fastighetsbyrån",
                        AgencyDescription = "Vi är Sveriges största mäklarkedja och stolta över att vara en del av Swedbank. Med över 300 kontor över hela landet erbjuder vi trygghet, lokal expertis och ett stort nätverk som gör din bostadsaffär smidig och säker. Vår passion är att hjälpa dig hitta rätt – oavsett om du ska köpa eller sälja.",
                        AgencyLogoUrl = "https://bilder.hemnet.se/images/broker_logo_2_2x/3d/53/3d53972640f121199879bf779e590c7d.jpg"
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 3,
                        AgencyName = "Länsförsäkringar Fastighetsförmedling",
                        AgencyDescription = "Hos oss får du mer än bara en mäklare – du får en trygg partner. Som en del av Länsförsäkringar-koncernen kombinerar vi djup lokal kunskap med försäkrings- och banktjänster, vilket ger dig en heltäckande och säker bostadsaffär. Vi finns nära dig för att göra bostadsdrömmen till verklighet.",
                        AgencyLogoUrl = "https://bilder.hemnet.se/images/broker_logo_2/73/c6/73c63376473b74a25e13711a82fcae60.png"
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 4,
                        AgencyName = "Svensk Fastighetsförmedling",
                        AgencyDescription = "Vi är en av Sveriges äldsta och mest pålitliga mäklarkedjor med ett starkt fokus på kundnöjdhet. Med vår stora erfarenhet och omfattande marknadsföring når vi ut till rätt köpare snabbt – så att du får bästa möjliga pris och en trygg försäljningsprocess.",
                        AgencyLogoUrl = "https://bilder.hemnet.se/images/broker_logo_2/73/80/7380eae8e412bea23a30d7cdd416f750.png"
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 5,
                        AgencyName = "SkandiaMäklarna",
                        AgencyDescription = "Vi är din personliga och engagerade mäklare med hjärtat i den lokala marknaden. Genom nära kundkontakt och skräddarsydd rådgivning ser vi till att din bostadsaffär blir så trygg och framgångsrik som möjligt. Vårt mål är att göra dig nöjd – varje steg på vägen.\r\n\r\n",
                        AgencyLogoUrl = "https://bilder.hemnet.se/images/broker_logo_2_2x/dd/7a/dd7a02fb5c0324de279ace72e14b873c.png"
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 6,
                        AgencyName = "Mäklarhuset",
                        AgencyDescription = "Välkommen till en mäklarkedja som sätter dig i fokus! Vi kombinerar rikstäckande närvaro med djup lokal expertis för att göra din bostadsaffär enkel, trygg och lönsam. Hos oss får du alltid personlig service och rådgivning anpassad efter dina behov.",
                        AgencyLogoUrl = "https://bilder.hemnet.se/images/broker_logo_2_2x/68/41/684184dc02af90e4f9d2ac612122b24f.png"
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 7,
                        AgencyName = "HusmanHagberg",
                        AgencyDescription = "Med över 20 års erfarenhet är vi en av Sveriges mest pålitliga och fristående mäklarkedjor. Vi brinner för att ge dig personlig service och lokalkännedom i världsklass, så att du kan känna dig trygg och nöjd genom hela bostadsresan.",
                        AgencyLogoUrl = "https://bilder.hemnet.se/images/broker_logo_2_2x/ff/d0/ffd046756118f2684c2df1061d0185c4.png"
                    }
                );
            });
            return builder;
        }


        public static ModelBuilder RealtorBuilder(ModelBuilder builder)
        {
            //Hasher for passwords
            var hasher = new PasswordHasher<Realtor>();

            builder.Entity<Realtor>().HasData(
                new Realtor
                {
                    Id = SeedGUID.SystemAdmin,
                    Email = "admin@bostadzportalen.com",
                    NormalizedEmail = "ADMIN@BOSTADZPORTALEN.COM",
                    UserName = "admin@bostadzportalen.com",
                    NormalizedUserName = "ADMIN@BOSTADZPORTALEN.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //BostadzPortalen
                    AgencyId = 1, //keep this as "empty" agency
                    PhoneNumber = "0722661920",
                    ProfileImageUrl = "https://genslerzudansdentistry.com/wp-content/uploads/2015/11/anonymous-user.png"
                },
                new Realtor
                {
                    Id = SeedGUID.SystemUser,
                    Email = "anders.johansson@fastighetsbyran.com",
                    NormalizedEmail = "ANDERS.JOHANSSON@FASTIGHETSBYRAN.COM",
                    UserName = "anders.johansson@fastighetsbyran.com",
                    NormalizedUserName = "ANDERS.JOHANSSON@FASTIGHETSBYRAN.COM",
                    FirstName = "Anders",
                    LastName = "Johansson",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //Fastighetsbyrån
                    AgencyId = 2,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/dc/10/dc1096e4429f9ab94cb951c2361c1d2c.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.SystemRealtor,
                    Email = "eric.hultman@fastighetsbyran.com",
                    NormalizedEmail = "ERIC.HULTMAN@FASTIGHETSBYRAN.COM",
                    UserName = "eric.hultman@fastighetsbyran.com",
                    NormalizedUserName = "ERIC.HULTMAN@FASTIGHETSBYRAN.COM",
                    FirstName = "Eric",
                    LastName = "Hultman",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //Fastighetsbyrån
                    AgencyId = 2,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/c2/14/c214891aaaaa4cc23e4cbb57a9b95bbd.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor1,
                    Email = "eric.svensson@lansforsakringar.se",
                    NormalizedEmail = "ERIC.SVENSSON@LANSFORSAKRINGAR.SE",
                    UserName = "eric.svensson@lansforsakringar.se",
                    NormalizedUserName = "ERIC.SVENSSON@LANSFORSAKRINGAR.SE",
                    FirstName = "Eric",
                    LastName = "Svensson",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //Länsförsäkringar
                    AgencyId = 3,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/28/49/2849c9de29bd992309e8e00aaec96d89.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor2,
                    Email = "christopher.sjodahl@lansforsakringar.se",
                    NormalizedEmail = "CHRISTOPHER.SJODAHL@LANSFORSAKRINGAR.SE",
                    UserName = "christopher.sjodahl@lansforsakringar.se",
                    NormalizedUserName = "CHRISTOPHER.SJODAHL@LANSFORSAKRINGAR.SE",
                    FirstName = "Christopher",
                    LastName = "Sjödahl",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //Länsförsäkringar
                    AgencyId = 3,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/7e/0c/7e0ceb545d876de2c344463e3def2b2b.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor3,
                    Email = "asa.danielsson@lansforsakringar.se",
                    NormalizedEmail = "ASA.DANIELSSON@LANSFORSAKRINGAR.SE",
                    UserName = "asa.danielsson@lansforsakringar.se",
                    NormalizedUserName = "ASA.DANIELSSON@LANSFORSAKRINGAR.SE",
                    FirstName = "Åsa",
                    LastName = "Danielsson",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //Länsförsäkringar
                    AgencyId = 3,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/93/66/9366e20a447c16f1c7a25c264fe4afba.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor4,
                    Email = "frida.urciuoli@fastighetsformedling.se",
                    NormalizedEmail = "FRIDA.URCIUOLI@FASTIGHETSFORMEDLING.SE",
                    UserName = "frida.urciuoli@fastighetsformedling.se",
                    NormalizedUserName = "FRIDA.URCIUOLI@FASTIGHETSFORMEDLING.SE",
                    FirstName = "Frida",
                    LastName = "Urciuoli",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //Fastighetsförmedling
                    AgencyId = 4,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/3e/9f/3e9fed971ede79ae8654200a71105a3a.png"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor5,
                    Email = "alf.jonsson@skandiamaklarna.se",
                    NormalizedEmail = "ALF.JONSSON@SKANDIAMAKLARNA.SE",
                    UserName = "alf.jonsson@skandiamaklarna.se",
                    NormalizedUserName = "ALF.JONSSON@SKANDIAMAKLARNA.SE",
                    FirstName = "Alf",
                    LastName = "Jonsson",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //SkandiaMäklarna
                    AgencyId = 5,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/fb/e0/fbe05166921e291c40f9d5f22c2403ee.png"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor6,
                    Email = "louise.pedersen@maklarhuset.com",
                    NormalizedEmail = "LOUISE.PEDERSEN@MAKLARHUSET.COM",
                    UserName = "louise.pedersen@maklarhuset.com",
                    NormalizedUserName = "LOUISE.PEDERSEN@MAKLARHUSET.COM",
                    FirstName = "Louise",
                    LastName = "Pedersen",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //Mäklarhuset
                    AgencyId = 6,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/0d/69/0d69c1adc73cb71ec67c0e48fcd6bf09.png"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor7,
                    Email = "max.hjertqvist@husmanhagberg.com",
                    NormalizedEmail = "MAX.HJERTQVIST@HUSMANHAGBERG.COM",
                    UserName = "max.hjertqvist@husmanhagberg.com",
                    NormalizedUserName = "MAX.HJERTQVIST@HUSMANHAGBERG.COM",
                    FirstName = "Max",
                    LastName = "Hjertqvist",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //HusmanHagberg
                    AgencyId = 7,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/c3/f1/c3f167f797358d672aa4c1d4b7ffc421.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor8,
                    Email = "garifalia.diakakis@fastighetsformedling.se",
                    NormalizedEmail = "GARIFALIA.DIAKAKIS@FASTIGHETSFORMEDLING.SE",
                    UserName = "garifalia.diakakis@fastighetsformedling.se",
                    NormalizedUserName = "GARIFALIA.DIAKAKIS@FASTIGHETSFORMEDLING.SE",
                    FirstName = "Garifalia",
                    LastName = "Diakakis",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //Fastighetsförmedling
                    AgencyId = 4,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/9c/a7/9ca77f4a03c12493a14c2acf6400b7db.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor9,
                    Email = "gustav.azelius@skandiamaklarna.se",
                    NormalizedEmail = "GUSTAV.AZELIUS@SKANDIAMAKLARNA.SE",
                    UserName = "gustav.azelius@skandiamaklarna.se",
                    NormalizedUserName = "GUSTAV.AZELIUS@SKANDIAMAKLARNA.SE",
                    FirstName = "Gustav",
                    LastName = "Azelius",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //SkandiaMäklarna
                    AgencyId = 5,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/f9/1e/f91ef13e8343b48609d5fc6462fc5b29.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor10,
                    Email = "tore.wikander@skandiamaklarna.se",
                    NormalizedEmail = "TORE.WIKANDER@SKANDIAMAKLARNA.SE",
                    UserName = "tore.wikander@skandiamaklarna.se",
                    NormalizedUserName = "TORE.WIKANDER@SKANDIAMAKLARNA.SE",
                    FirstName = "Tore",
                    LastName = "Wikander",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //SkandiaMäklarna
                    AgencyId = 5,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/f6/da/f6da5fe256d9d155fd6e291460c6f95b.jpg"
                }
            );
            return builder;
        }

        public static ModelBuilder IdentityUserRoleBuilder(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleRealtor,
                    UserId = SeedGUID.SystemUser
                },
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleAdmin,
                    UserId = SeedGUID.SystemAdmin
                },
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleRealtor,
                    UserId = SeedGUID.SystemRealtor
                },
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleRealtor,
                    UserId = SeedGUID.Realtor1
                },
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleRealtor,
                    UserId = SeedGUID.Realtor2
                },
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleRealtor,
                    UserId = SeedGUID.Realtor3
                },
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleRealtor,
                    UserId = SeedGUID.Realtor4
                },
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleRealtor,
                    UserId = SeedGUID.Realtor5
                },
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleRealtor,
                    UserId = SeedGUID.Realtor6
                },
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleRealtor,
                    UserId = SeedGUID.Realtor7
                },
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleRealtor,
                    UserId = SeedGUID.Realtor8
                },
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleRealtor,
                    UserId = SeedGUID.Realtor9
                },
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleRealtor,
                    UserId = SeedGUID.Realtor10
                }
            );
            return builder;
        }

        public static ModelBuilder MunicipalityBuilder(ModelBuilder builder)
        {
            builder.Entity<Municipality>().HasData(
                new Municipality { Id = 1, Name = "Umeå" },
                 new Municipality { Id = 2, Name = "Stockholm" },
                 new Municipality { Id = 3, Name = "Luleå" },
                 new Municipality { Id = 4, Name = "Malmö" },
                 new Municipality { Id = 5, Name = "Göteborg" },
                 new Municipality { Id = 6, Name = "Visby" },
                 new Municipality { Id = 7, Name = "Sundsvall" },
                 new Municipality { Id = 8, Name = "Gävle" },
                 new Municipality { Id = 9, Name = "Skellefteå" },
                 new Municipality { Id = 10, Name = "Örnsköldsvik" },
                 new Municipality { Id = 11, Name = "Uppsala" }
                );

            return builder;
        }


        public static ModelBuilder PropertyForSaleBuilder(ModelBuilder builder)
        {
            builder.Entity<PropertyForSale>().HasData(
                new PropertyForSale
                {
                    PropertyForSaleId = 1,
                    MunicipalityId = 1,
                    RealtorId = SeedGUID.SystemUser,
                    AskingPrice = 2295000,
                    MonthlyFee = 0,
                    YearlyOperatingCost = 15827,
                    LivingArea = 83,
                    PlotArea = 1958,
                    SupplementaryArea = 0,
                    YearBuilt = 1971,
                    Address = "Tallmovägen 10",
                    Description = "Välkomna till detta charmiga hus med en fantastisk trädgård och ett eftertraktat läge, bara fyra kilometer från centrala Obbola. Området erbjuder härliga promenadstråk och närhet till flera populära havsbadstränder, vilket gör detta till en idealisk plats att bo på.\r\nHuset rymmer fyra smakfulla rum, där köket flyter samman med vardagsrummet i en öppen planlösning – den perfekta ytan för samvaro. \r\nBadrummet är renoverat, och en praktisk, separat tvättstuga finns också att tillgå. Den generösa söderaltanen bjuder på sol hela dagen och en underbar utsikt över den insynsskyddade och välskötta trädgården.",
                    NumberOfRooms = 4,
                    TypeOfProperty = TypeOfPropertyEnum.Villa
                },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 2,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.SystemRealtor,
                     AskingPrice = 1995000,
                     MonthlyFee = 5267,
                     YearlyOperatingCost = 0,
                     LivingArea = 40,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1952,
                     Address = "Svärdlångsvägen 19A",
                     Description = "Nu erbjuds möjligheten att förvärva denna välrenoverade etta där samtliga kvadratmeter är perfekt disponerade med imponerande takhöjd om 3.5m. Tack vare smart lösning med sovalkov direkt in till vänster får ni utan problem plats med soffgrupp med tillhörande möblemang, kontorshörna samt matbord för 4-6 personer. Med ett fullt utrustat kök, stambytt badrum samt ett fantastiskt ljusinsläpp från stora fönsterpartier är detta en lägenhet att trivas i. Genomgående fräscha ytskikt, här är det bara att flytta in. Byggnaderna ritades ursprungligen av arkitekt Åke E Lindqvist och användes som skola mellan åren 1952-1992 och byggdes sedan om till bostäder 1999.\r\nPerfekt beläget i ett lugnt område mellan Årsta Torg och Årstaberg med goda kommunikationer som pendeltåg, tvärbana och bussar. Busshållplats utanför porten. Närhet till Årstaviken som erbjuder löpspår, utegym och härliga skogspromenader. Som närmsta granne finns vackra storängsparken med härliga grönytor och lekplatser. På 10 minuter tar ni er enkelt till Södermalm med fina cykelvägar.",
                     NumberOfRooms = 1,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 3,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.SystemRealtor,
                     AskingPrice = 15300000,
                     MonthlyFee = 8996,
                     YearlyOperatingCost = 24540,
                     LivingArea = 158,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 2025,
                     Address = "Vinkelhuset",
                     Description = "Stor balkong med utsikt över Mälarens glittrande vatten. Våningen erbjuder generösa sällskapsytor som är i öppen planlösning med köket. Den flexibla planlösningen ger möjlighet till upp till fyra sovrum, där en del kan göras om till en separat avdelning, perfekt som kontor eller för uthyrning.\r\n\r\n\r\n\r\nKöket är från Kvänum med köksluckor och hyllor är i ek hazel, med bänkskiva och stänkskydd i Thala Grey kalksten. Helintegrerad kyl, frys och diskmaskin samt induktionshäll med integrerad fläkt och varmluftsugn. Alla vitvaror från Miele. Väggarna i duschutrymmet och klinker på golvet är i Bricmate Rune Light Grey. Lådor är i valnöt från Haven, handfatet är i kvartskomposit och blandaren från Tapwell. All förvaring är från WL Systems.\r\n\r\n\r\n\r\nEtt sofistikerat och tidlöst boende. Genom att se bortom invanda mönster utvecklar vi vackra, genomtänkta och personliga hem. Hem som du kan leva i och beröras av länge.",
                     NumberOfRooms = 5,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 4,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor1,
                     AskingPrice = 1995000,
                     MonthlyFee = 4489,
                     YearlyOperatingCost = 3600,
                     LivingArea = 62,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1901,
                     Address = "Frida Åslunds gränd 1C",
                     Description = "Välkommen till denna ljusa och fina tvåa på Sandåkern närmast Tvärån. Lägenheten är mycket välplanerad och flödar av ljus via stora fönster med fin utsikt från vardagsrum, kök, sovrum och badrum. Inglasad balkong som vetter mot innergård, med sol fram till cirka klockan tre. Lägenheten har en vacker omgivning är granne med Tvärån. Promenadavstånd till centrum, affär, fina promenadstråk och strandpromenaden. Busshållplats finns nära bostaden.",
                     NumberOfRooms = 2,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 5,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor1,
                     AskingPrice = 2995000,
                     MonthlyFee = 0,
                     YearlyOperatingCost = 21597,
                     LivingArea = 81,
                     PlotArea = 1938,
                     SupplementaryArea = 0,
                     YearBuilt = 1963,
                     Address = "Svajetvägen 40",
                     Description = "Välkommen till detta utbyggda och renoverade sommarparadis beläget på mycket attraktivt läge. Den vackra utsikten över havet är slående oavsett om du befinner dig utomhus eller kliver in i stugans stilrena och vilsamma miljö. Stugan är utbyggd och smakfullt renoverad och håller en hög standard där de sociala ytorna är generösa och mycket tilltalande. Kök, matplats och vardagsrum integrerar i öppen planlösning med havet i ständigt blickfång genom stora fönsterpartier som verkligen sätter prägel på ditt boende. En öppen spis ger extra mysfaktor. Utöver de sociala ytorna disponeras två sovrum samt ett rymligt badrum med tvättstuga. På tomten finns även två renoverade gäststugor och ett intilliggande förråd. En rymlig altan länkar samman flera av byggnaderna samt erbjuder flera solfyllda uteplatser med utrymme för exempelvis utekök, loungedel, matplats och solplats. Med andra ord finns gott om utrymme för familj och vänner att rymmas och för dig bara att flytta in och njuta av ditt nya sommarparadis! Möjlighet till snabbt tillträde! \r\nNedanför stugan når du en mindre sandstrand och inte långt bort ligger den mysiga stranden vid Karthällan. Närheten till havet innebär aktiviteter i princip året runt! Sommartid kan du bada, göra utflykter med cykel och båt eller varför inte bara ströva i skogen för svamp-bärplockning. När isen lagt sig kan du åka skridskor, skidor och skoter. Här finns också möjlighet till fiske. Sörmjöle är ett populärt sommar- och åretruntboende med bra pendlingsavstånd till Umeå.",
                     NumberOfRooms = 3,
                     TypeOfProperty = TypeOfPropertyEnum.Fritidshus
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 6,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor1,
                     AskingPrice = 2195000,
                     MonthlyFee = 6239,
                     YearlyOperatingCost = 22629,
                     LivingArea = 97,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1964,
                     Address = "Tallparksvägen 17A",
                     Description = "Välkommen till denna  4:a på eftertraktad adress på Grisbacka, med ett kanonläge och en inglasad balkong i söder. Denna lägenhet erbjuder rymliga rum med en praktisk planlösning som passar perfekt för familjen. Det trivsamma köket har en matplats som inbjuder till trevliga måltider, medan det stora och luftiga vardagsrummet ger gott om utrymme för avkoppling och sociala stunder.\r\nDen inglasade balkongen i söderläge är perfekt för att njuta av soliga dagar. Bostaden har också ett duschrum med tvättmaskin, en separat gäst-WC och ett rymligt master-bedroom. De två multifunktionella extrarummen kan enkelt anpassas till barnrum, kontor eller gästrum, beroende på dina behov.\r\nLägenheten ligger i en välskött förening med en stor och trivsam innergård där barnen kan leka på lekplatsen. På Tallparksvägen bor du i ett lugnt och omtyckt område, perfekt perfekt för dig som värdesätter närhet till centrum, mataffärer, motionsspår och skolor. Goda kommunikationer finns till både universitetet och NUS, vilket gör lägenheten perfekt för pendling.\r\nMissa inte chansen att uppleva denna bostad – boka din visning idag!\r\nVarmt välkommen!",
                     NumberOfRooms = 4,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 7,
                     MunicipalityId = 9,
                     RealtorId = SeedGUID.Realtor1,
                     AskingPrice = 1675000,
                     MonthlyFee = 0,
                     YearlyOperatingCost = 38256,
                     LivingArea = 141,
                     PlotArea = 981,
                     SupplementaryArea = 56,
                     YearBuilt = 1962,
                     Address = "Björkgatan 11",
                     Description = "Med sin vackra tegelstensfasad och genomtänkta planlösning erbjuder detta 1 ½-planshus en perfekt kombination av komfort och funktionalitet. Här finns hela 141 kvm boyta och 56 kvm biarea, fördelat på fem rymliga sovrum vilket gör det till ett utmärkt hem för den stora familjen.\r\nTomten på 981 kvm är lummig och välskött med gräsmatta, träd och buskar, och den härliga uteplatsen i söderläge bjuder in till avkopplande stunder i solen. Huset har dessutom bergvärme, vilket ger energieffektiv uppvärmning året runt.  Ny bergvärmepump installerad april 2025, komplett med garantier.\r\nFör dig som behöver gott om förvaringsutrymmen finns både ett varmförråd på garagevinden och ett praktiskt varmgarage. Läget är optimalt – centralt i Bureå men på en lugn gata, precis intill skola, förskola, simhall, hockeyplan, fotbollsplan, elljusspår och skog, vilket gör vardagen smidig och bekväm.\r\nHuset är besiktat och Varudeklarerad inför försäljning för din trygghet. Missa inte chansen att skapa ditt drömhem här – varmt välkommen att boka visning!",
                     NumberOfRooms = 6,
                     TypeOfProperty = TypeOfPropertyEnum.Villa
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 8,
                     MunicipalityId = 9,
                     RealtorId = SeedGUID.Realtor1,
                     AskingPrice = 4500000,
                     MonthlyFee = 0,
                     YearlyOperatingCost = 52093,
                     LivingArea = 135,
                     PlotArea = 1647,
                     SupplementaryArea = 0,
                     YearBuilt = 1960,
                     Address = "Boviksbadet 408",
                     Description = "Här på Boviksbadet 408, endast 15 minuter från stan, väntar ett inflyttningsklart drömboende med egen pool, gästhus och stora uteplatser som bjuder in till soliga dagar och ljumma kvällar.\r\nStarta morgonen med ett dopp i poolen, spendera dagen på någon av de vackra badstränderna och avsluta med en grillmiddag medan solen sänker sig bakom trädtopparna. Här är det lätt att koppla av och njuta av sommarens bästa stunder!\r\nDet stilfulla fritidshuset har genomgått en omfattande renovering och erbjuder en perfekt mix av modern komfort och somrig charm. Här möts du av en ljus och fräsch interiör med nytt kök från 2023, generösa sällskapsytor och tre sovrum, vilket gör det enkelt att umgås med familj och vänner.\r\nUteplatsen är en riktig oas skapad för njutning och avkoppling. Den nyrenoverade poolen (2024) med nytt pooltäcke och egen luftvärmepump blir snabbt den naturliga samlingspunkten för hela familjen.\r\nRunt poolen finns stora soldäck och uteplatser, perfekta för lata dagar i solen eller härliga grillkvällar med nära och kära. Gäststugan och den mindre jadestugan ger gott om plats för övernattande gäster och skapar en exklusiv känsla av en privat semesteranläggning.\r\nEldstaden skapar en mysig atmosfär under svalare kvällar, och med fiberanslutning kan du enkelt jobba på distans eller streama sommarens favoriter.\r\nLäget är oslagbart! Med promenadavstånd till badstränder, en populär camping med sommarrestaurang och natursköna omgivningar finns alla förutsättningar för en perfekt sommar. Här får du det bästa av två världar – total avkoppling vid havet och närhet till stadens bekvämligheter.\r\nDetta är inte bara en sommarstuga – det är en livsstil! Ett nyckelfärdigt sommarboende i toppskick, där du kan njuta från första stund. Missa inte chansen att göra detta till din egen sommaridyll – välkommen att boka visning!",
                     NumberOfRooms = 3,
                     TypeOfProperty = TypeOfPropertyEnum.Fritidshus
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 9,
                     MunicipalityId = 9,
                     RealtorId = SeedGUID.Realtor1,
                     AskingPrice = 2650000,
                     MonthlyFee = 0,
                     YearlyOperatingCost = 58054,
                     LivingArea = 145,
                     PlotArea = 1160,
                     SupplementaryArea = 48,
                     YearBuilt = 1926,
                     Address = "Styrmansgatan 23",
                     Description = "Här bor du i en smakfullt renoverad fastighet där den klassiska 30-talskaraktären möter modern funktionalitet.\r\nHuset ligger på ett bekvämt avstånd från allt du behöver – bara 200 meter till mataffär och bussförbindelser samt 100 meter till närmaste lekpark, vilket ger en perfekt balans mellan lugn och närhet till service. Här har du en fin utsikt över Ursviksfjärden från husets kök, badrum, sovrum och balkong.\r\nHuset har genomgått flera uppdateringar, bland annat ett nyrenoverat tak (2023), kök (2020), badrum (2025) och fjärrvärme. Allt detta kombineras med en härlig atmosfär och gedigna materialval.\r\nNär du kliver in i entrén möts du av en välkomnande yta för avhängning. Härifrån fortsätter du vidare in i det rymliga vardagsrummet, där de tidstypiska pardörrarna ger en känsla av elegans och charm.\r\nKöket är öppet mot matrummet och erbjuder en praktisk lösning med en stor flyttbar köksö, perfekt för stora middagar och familjesammankomster. Från matplatsen når du den soliga, stora verandan som har rymt upp till 20 sittplatser. Verandan vetter åt väster, vilket ger dig sol från lunch till resten av kvällen.\r\nTakhöjden på entréplanet når ca 3 meter, vilket tillsammans med tidstypiska detaljer så som en eldningsbar järnspis, gör att du lätt kan känna historiens vingslag.\r\nPå övre plan finns tre bra sovrum varav ett med en vacker eldningsbar kakelugn. Ett nyrenoverat badrum samt även ett allrum som är perfekt för avkoppling och mysiga stunder framför braskaminen. En trappa leder upp till den oinredda vinden, som erbjuder möjlighet att skapa mer yta efter behov.\r\nUte finns en underbar uppvuxen trädgårdstomt med fruktträd, hallonbuskar och rabarber – en perfekt plats för både odling och avkoppling. Mellan garage och veranda är det stenlagt, och på uppfarten finns gott om plats. Ett stort varmbonat dubbelgarage på ca 56 m² erbjuder bra utrymme för hobbys och förvaring.\r\nKällaren har förutom en trappa ner även en separat ingång och rymmer matkällare och tvättstuga samt ett ombonat rum, perfekt som tonårsrum eller gästrum. Här kan du verkligen få plats med hela familjen och deras behov.\r\nStyrmansgatan 23 är en unik möjlighet för dig som söker ett hus med både karaktär, funktion samt garage – Varmt välkommen att boka visning på vår hemsida!",
                     NumberOfRooms = 6,
                     TypeOfProperty = TypeOfPropertyEnum.Villa
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 10,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor1,
                     AskingPrice = 1200000,
                     MonthlyFee = 0,
                     YearlyOperatingCost = 46585,
                     LivingArea = 134,
                     PlotArea = 1136,
                     SupplementaryArea = 101,
                     YearBuilt = 1971,
                     Address = "Åkerviksvägen 24",
                     Description = "Välkommen till Åkerviksvägen 24 i charmiga Botsmark – en friliggande villa som erbjuder en perfekt kombination av rymlighet och naturnära boende. Med en boyta på 134 m² och en biyta på 101 m² fördelat på 5 rum, varav 3 sovrum, finns här gott om plats för hela familjen. Tomten på 1 136 m² är uppvuxen och erbjuder ett öppet och fritt läge, perfekt för trädgårdsentusiasten eller för barnens lek.?\r\nDenna 1½-plansvilla med källare är byggd för att möta behoven hos en växande familj eller för dig som söker extra utrymme för hobbyverksamhet eller hemmakontor. Botsmark erbjuder en lugn och trivsam miljö med närhet till naturen, samtidigt som Umeås stadskärna nås inom rimligt avstånd för arbete och nöjen.\r\nBotsmark präglas av en stark gemenskap och arrangerar årligen Botsmarksdagen, en dag fylld med marknadsstånd, hantverk, lotterier och barnaktiviteter. Detta evenemang, vanligtvis i augusti, är ett utmärkt tillfälle att uppleva den lokala kulturen och träffa byborna.\r\nOavsett årstid finns det aktiviteter att utforska. Vintertid kan du njuta av skoteråkning, skidåkning och pulkaåkning, medan sommaren bjuder på bad i insjöar, vandringar och möjligheter till olika bollsporter på de öppna ängarna.\r\nSammanfattningsvis erbjuder Botsmark en harmonisk blandning av naturskönhet, kulturella evenemang och fritidsaktiviteter, vilket gör det till en attraktiv plats för både boende och besökare som söker en lugn och aktiv livsstil.\r\nFör den naturintresserade finns Västermarks naturreservat några kilometer från Botsmark. Här kan du vandra eller åka skidor längs markerade leder.\r\nEn annan sevärdhet är världens största flyttblock och grottor i närheten av Botsmark, vilket gör området till ett spännande utflyktsmål för familjer och äventyrslystna.\r\nTa chansen att förvärva denna pärla i hjärtat av Västerbotten!",
                     NumberOfRooms = 5,
                     TypeOfProperty = TypeOfPropertyEnum.Villa
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 11,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor1,
                     AskingPrice = 1190000,
                     MonthlyFee = 4024,
                     YearlyOperatingCost = 5616,
                     LivingArea = 63,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1970,
                     Address = "Kemigränd 29",
                     Description = "Tvåa centralt i studentstaden Umeå. Passar student då det är nära till både universitetssjukhuset och universitetet. Dessutom finns Ålidhem centrum med dess restauranger, mataffärer och serviceutbud inom gångavstånd. För dig som gillar mysiga promenader finns Ålidparken.\r\nBostaden är bra planerad och erbjuder ett rymligt vardagsrum, kök med separat matplats, ett sovrum samt badrum med tvättmaskin. Till bostadsrätten hör ett förråd som är beläget på samma våningsplan. Väldigt praktiskt när saker ska hämtas och lämnas.\r\nEnligt föreningen är ekonomin stabil. Föreningen tillhandahåller välvårdad gemensam innergård för de boende i huset. Här finns sittmöbler och grillplats. Parkeringsplats och varmgarage kan hyras enligt separat kö via föreningen.\r\nVälkommen på visning!",
                     NumberOfRooms = 2,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 12,
                     MunicipalityId = 3,
                     RealtorId = SeedGUID.Realtor1,
                     AskingPrice = 1295000,
                     MonthlyFee = 4660,
                     YearlyOperatingCost = 972,
                     LivingArea = 60,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1947,
                     Address = "Yrkesgatan 46",
                     Description = "Välkommen till denna trevliga 2:a på våning 2 i Brf Stålet. Bostaden har ett ljust kök med både bra förvaring och arbetsytor samt full maskinell utrustning. I köket finns plats för mindre matgrupp invid fönster. Öppningen in mot vardagsrummet bidrar till den ljusa och öppna känslan. I det luftiga vardagsrummet finns plats för både soffgrupp och större matgrupp. Här nås även den trivsamma balkongen. Sovrummet är rymligt och inrymmer dubbelsäng med lätthet, här finns både förvaring via garderober samt klädkammare i anslutning. Badrum med våtrumsmatta på väggar och golv, samt en rymlig hall med goda möjligheter för avhängning och ytterligare möjlighet för förvaring om så önskas. \r\n\r\n\r\n\r\nI källaren finns ett mindre förråd samt ett större förråd att disponera, i det större förrådet finns praktiskt en klädvårdsavdelning med tvättmaskin och torktumlare samt förvaringsmöjligheter längs ena väggen. Till lägenheten hör också en motorvärmarplats belägen direkt invid huset. Garageplatser finns i föreningen och dessa fördelas enligt separat kö. \r\n\r\n\r\n\r\nBrf Stålet är en förening om 120 lägenheter fördelat på 30 huskroppar. I månadsavgiften ingår värme, vatten, kabel-tv, bredband, fast kostnad för IP-telefoni, motorvärmarplats samt bostadsrättstillägg till hemförsäkringen. Föreningen tillämpar enhetsmätning av elen vilket innebär att lägenhetsinnehavaren endast betalar för den förbrukade elen och föreningen står för de fasta kostnaderna. Skurholmen är ett populärt bostadsområde med blandade boendeformer. Goda bussförbindelser till både centrum, Luleå Tekniska Universitet och Sunderby Sjukhus. Närhet till matvarubutik, apotek och restauranger.",
                     NumberOfRooms = 2,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 13,
                     MunicipalityId = 10,
                     RealtorId = SeedGUID.Realtor1,
                     AskingPrice = 1595000,
                     MonthlyFee = 3449,
                     YearlyOperatingCost = 4260,
                     LivingArea = 59,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1962,
                     Address = "Nygatan 6F",
                     Description = "Bo högt upp mitt i city – en modern och smakfull välrenoverad pärla!\r\nVälkommen till en superfin och inflyttningsklar lägenhet där modern stil och funktion möts på ett fantastiskt sätt! Här bor du på ett svårslaget läge, med stadens puls precis runt hörnet. Lägenheten har genomgått en smakfull renovering 2022 och erbjuder ett rymligt och elegant kök, ett helkaklat badrum i toppskick samt ett ljust och inbjudande vardagsrum med charmigt burspråk och utgång till balkong. Stabil förening och en bostad där du bara kan flytta in och börja trivas från dag ett.\r\nKontakta mäklaren för mer information eller för att boka in en förhandsvisning!",
                     NumberOfRooms = 2,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 14,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor2,
                     AskingPrice = 6150000,
                     MonthlyFee = 6685,
                     YearlyOperatingCost = 16622,
                     LivingArea = 88,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1964,
                     Address = "Aspnäsvägen 12",
                     Description = "Välplanerad 4:a med radhuskänsla belägen på den lummiga delen av Näset, återvändsgatan Aspnäsvägen. 88 välplanerade kvm i genomgående bra skick med öppen planlösning, tre bra sovrum och två badrum samt en stor uteplats i sydvästligt läge gör detta till ett perfekt substitut för radhus. Förråd på samma våningsplan vilket är smidigt. Välskött förening med god ekonomi. Näset är ett populärt område på Lidingö med både centralt och lugnt läge. Här bor du nära både natur och grönområden med fina promenadstråk samtidigt om du bara har ca 8 minuter till Ropsten med buss. För dig som gillar att cykla finns bra cykelvägar. På Källängstorget finns matbutik och restaurang. Välkommen att kontakta ansvarig mäklare för mer information!",
                     NumberOfRooms = 4,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 15,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor2,
                     AskingPrice = 2995000,
                     MonthlyFee = 4168,
                     YearlyOperatingCost = 52544,
                     LivingArea = 57,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1943,
                     Address = "Pastellvägen 30",
                     Description = "Välkommen till denna ljusa och insynsskyddade gavelbostad på eftertraktade Pastellvägen. Med fönster i tre väderstreck flödar naturligt ljus in från morgon till kväll, vilket skapar en luftig och trivsam atmosfär. Rymligt vardagsrum med stora fönster som bjuder på härlig utsikt och vackert ljusinsläpp. Trevligt fullutrustat kök med gott om utrymme för matlagning och matplats. Goda förvaringsmöjligheter i lägenheten samt ett källarförråd. \r\nHär bor du med ett fantastiskt läge i härliga och attraktiva Johanneshov som erbjuder grönskande parker och bra restauranger och fik. Gamla Enskede Matbod, Robin Delselius bageri och Matateljén är bara några exempel. På 3 minuter kommer du till Blåsut där T-banan tar dig in till Söder på endast 6 min. Här finns även bra cykelvägar som tar dig in på 10 minuter. I Sandsborg finns ICA Supermarket, apotek och Sandsborgsbadet. Inom räckhåll har du även Globenområdet där det finns gott om shopping, restauranger och matbutiker. I närheten finns 3 arena och Hovet som erbjuder många spännande evenemang.",
                     NumberOfRooms = 3,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 16,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor3,
                     AskingPrice = 5995000,
                     MonthlyFee = 7942,
                     YearlyOperatingCost = 18391,
                     LivingArea = 124,
                     PlotArea = 0,
                     SupplementaryArea = 7,
                     YearBuilt = 2019,
                     Address = "Skvadronvägen 60 B",
                     Description = "Välkommen till denna exklusiva bostadsrätt i Brf Skvadronhöjden, belägen i det populära området Tingvalla i Vallentuna. Med en boyta på 124 kvadratmeter och fem rum erbjuder detta hem generösa ytor för hela familjen att trivas i.\r\nDet som verkligen utmärker denna bostad är dess unika fördelar som takterass, bastu samt uppvuxen välskött trädgård med uteplats. På takterassen kan du njuta av solens strålar och vid den uppvuxna trädgården kan du koppla av i en fridfull miljö. Med en uteplats för trevliga middagar och sociala stunder utomhus får du en perfekt plats att umgås och skapa minnen tillsammans. Bastu finns i bostaden och parkering och förråd ingår också.\r\nOmrådet Tingvalla erbjuder lugn och ro samtidigt som det har gott om bekvämligheter inom räckhåll. Här finns närhet till skolor, service och grönområden för avkoppling och rekreation.\r\nDenna bostadsrätt är inte bara ett hem, det är en investering i livskvalitet och gemenskap. Passa på att ta chansen att bli en del av detta harmoniska bostadsområde i Vallentuna. Kontakta oss för visning och upplev allt detta hem har att erbjuda!",
                     NumberOfRooms = 6,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättsradhus
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 17,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor3,
                     AskingPrice = 2895000,
                     MonthlyFee = 6131,
                     YearlyOperatingCost = 8088,
                     LivingArea = 75,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 2022,
                     Address = " Vallhöjdsvägen 19",
                     Description = "Välkommen till Vallhöjdsvägen 19 i det natursköna området Kallfors, Järna. Denna moderna bostadsrätt från 2022 erbjuder 75 kvm boyta fördelat på 3 rum och kök, allt i nyskick. Belägen på bottenvåningen med en generös balkong om 20 kvm, får du här ett boende som kombinerar komfort med stil. Välkomna på visning av er nya bostad!",
                     NumberOfRooms = 3,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 18,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor4,
                     AskingPrice = 3500000,
                     MonthlyFee = 0,
                     YearlyOperatingCost = 49442,
                     LivingArea = 71,
                     PlotArea = 2308,
                     SupplementaryArea = 28,
                     YearBuilt = 2013,
                     Address = "Abborrens väg 4",
                     Description = "I populära Vätö (Klockarängen) ligger denna soliga och välskötta fastighet på hörntomt utan insyn!\r\nVälkommen till ett drömlikt boende med huvudbyggnad från 2013, stort gästhus med flertalet bäddar samt med naturen som granne.\r\nHär bor ni skärgårdsnära med närhet till havsbad på fin strand, möjlighet till båtplats samt vackra strövområden och vandringsleder i fantastiska omgivningar.\r\nDetta lyxiga fritidshus lämpar sig väl även som permanentboende med ett hus om ca. 71 kvm (Entréplan) samt ett stort allrum på övre plan.\r\nHuvudbyggnaden erbjuder två stora sovrum, vardagsrum/kök i öppen planlösning med värmande täljstenskamin. Köket är bra utrustat med t.ex. diskmaskin och plats för köksbord åt 8 personer. Från kök/vardagsrum finns dörr ut till stora altanen. Badrummet erbjuder dusch, snålspolande vattentoalett, tvättmaskin och bastu.\r\nUtöver huvudbyggnad finns ett gästhus, om ca. 42 kvm. Här finns vardagsrum, litet kök, sovrum samt ett toalettrum.\r\nUtöver detta finns två friggebodar om ca. 10 kvm & 12kvm.\r\nHörntomten om 2 308 kvm ligger insynsskyddat har en härlig mix av trädgård- och naturtomt med berg i dagen. Trädgården klarar sig till stor del på egen hand och är välplanerad med gräsytor, planteringar och blommor. De intilliggande skogarna erbjuder gott om svamp och bär precis som på denna tomt. Favoritplatsen är helt klart den trädäckade altan på berget med paviljong och växthus!\r\nFastigheten har tillgång till vatten året runt in till huvudbyggnad via egen borrad brunn samt är kopplad till godkända avlopp. Man har också tillgång till sommarvatten via samfällighetsförening. Här finns också fiber som möjliggör distansarbete likväl som tonåringars spellystnad.\r\nDet har gjorts ett flertal stora renoveringar under de senaste åren. Se längre ner i annonsen för mer information om dessa renoveringar. Här kan man verkligen koppla av från dag 1 då allt är välskött, renoverat och i bra skick!\r\nDetta boende erbjuder aktiviteter året om när årstiderna skiftar. Bad om sommaren sker på badstranden i området som också har ett hopptorn. Vid badstranden har man också möjlighet till båtplats på välskötta båtbryggor. Ni har närhet till områdets välskötta grönområden med bl.a. fotbollsplan för lek och spel samt boulebana. I Harg finns det matbutik, skola och dagis och i Nysättra strax före Vätöbron finns bygghandel, pizzeria och kiosk. Ni har 14 km till Roslagens golfbana där det på vintertid finns en slinga på 7 km för skidor. 3,5 km till populära Vätö självplock och färska jordgubbar. Ni har 85 km med bil till Stockholm och 20 km till Norrtälje. Roslagen har ett fint vägnät för landsvägscykling. Fastigheten ligger med närhet till bondgård med möjlighet till hästridningslektioner.\r\nNi har 300 m till närmaste busshållplats (buss nr 638) som tar dig direkt in till Norrtälje på 55 minuter.\r\nVälkommen med din visningsanmälan!",
                     NumberOfRooms = 3,
                     TypeOfProperty = TypeOfPropertyEnum.Fritidshus
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 19,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor4,
                     AskingPrice = 1495000,
                     MonthlyFee = 4711,
                     YearlyOperatingCost = 42714,
                     LivingArea = 35,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1929,
                     Address = "Agatvägen 28",
                     Description = "Kontakta mäklaren för privatvisning!\r\nVälkommen till denna fantastiskt charmiga och välplanerade lägenhet, belägen i ett vackert 30-talshus med bevarade originaldetaljer. Här möts du av stora spröjsade fönster med djupa nischer, generös takhöjd och en genomtänkt planlösning som gör bostaden perfekt för både singelhushållet och paret. Bostaden ligger i hjärtat av idylliska Beckomberga och präglas av ett härligt ljusinsläpp från tre stora fönster i fil. Här bor du i en stabil och välskött förening där både bredband och TV ingår i månadsavgiften. Dessutom erbjuds gratis parkering inom föreningen – en sällsynt förmån i Stockholm! Fastigheten genomgick en omfattande renovering mellan 2002–2004, inklusive stambyte.\r\nEtt område med närhet till allt. Beckomberga har de senaste åren vuxit fram som ett av Brommas mest eftertraktade bostadsområden. Här trivs du som söker lugn och grönska, samtidigt som du har smidig access till city – endast 15 minuter bort. Området erbjuder ett stort utbud av förskolor och skolor, däribland Beckombergaskolan, Raoul Wallenbergs skola och Kastanjelundens förskola. Kommunikationerna är utmärkta med buss 117, som tar dig till Brommaplan på 5–7 minuter, samt närhet till både Spånga station och tunnelbanans gröna linje vid Islandstorget och Råcksta.\r\nI området finns två välsorterade matbutiker och flera omtyckta restauranger och caféer, såsom Café Blå Koppen, Bromma Bistro och Arigato Sushi. För den träningsintresserade finns gymmet Puls & Träning, simhall och sporthall i närheten, samt fina promenadstråk för avkopplande stunder i naturen.",
                     NumberOfRooms = 1,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 20,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor5,
                     AskingPrice = 5495000,
                     MonthlyFee = 0,
                     YearlyOperatingCost = 30905,
                     LivingArea = 124,
                     PlotArea = 382,
                     SupplementaryArea = 0,
                     YearBuilt = 2022,
                     Address = "Bagarstugans väg 42",
                     Description = "\"Området är som en oas med kort gångavstånd till Stockholms bästa brunch på Stenladan, en perfekt strand finns i närheten för att doppa sig dem varma dagarna. Vi har speciellt uppskattat naturen med flertalet vandringsstigar, grönska och djurliv. Utöver det kommer marinan strax vara färdigrenoverad, skola samt förskola byggd samt stallet fyllas med olika hästar.\"\r\nVälkommen till detta vackert designade friköpta parhus med oslagbart läge i Steninge Slottsby! Materialvalen följer som en röd tråd genom hela bostaden och färgnyanserna kopplar ann till naturen runtomkring. Här bor du med naturen som närmsta granne och all bekvämlighet en familj kan tänka sig. Tack vare gavelläget har du mer ljusinsläpp och ett friare läge i området. Huset som stod färdigt 2023 är en del av bostadskvarteret Solfjädern med totalt tio unika parhus om 124 kvadratmeter med 5 rum och kök ritade av arkitekterna på Blooc. Fastigheten kommer att anslutas till en samfällighet för skötsel av vägar och gemensamma ytor i området. Att bo i Steninge Slottsby är förenat med livskvalitet och hela området är omgivet av natur.",
                     NumberOfRooms = 5,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättsradhus
                 }
                );

            return builder;

        }
        public static ModelBuilder SeedPropertyImages(this ModelBuilder builder)
        {
            builder.Entity<PropertyImage>().HasData(
                new PropertyImage
                {
                    Id = 1,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/ac/f1/acf19745115e18c49dd040a84fd2660f.jpg",
                    PropertyForSaleId = 1
                },
                new PropertyImage
                {
                    Id = 2,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/be/88/be88d78da8f65c5d303b25fbbe5fed59.jpg",
                    PropertyForSaleId = 1
                },
                new PropertyImage
                {
                    Id = 3,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/90/d6/90d6a28ed3f53038d2e0499ebe3fd507.jpg",
                    PropertyForSaleId = 1
                },
                new PropertyImage
                {
                    Id = 4,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/76/d8/76d8499e86ab1edd3ec980aa0bc0f942.jpg",
                    PropertyForSaleId = 2
                },
                new PropertyImage
                {
                    Id = 5,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/eb/c5/ebc54c89f9033d97441574682cc0f9c9.jpg",
                    PropertyForSaleId = 2
                },
                new PropertyImage
                {
                    Id = 6,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/e4/f5/e4f5ab0a2cddda36e2da1c37088e24ed.jpg",
                    PropertyForSaleId = 2
                },
                new PropertyImage
                {
                    Id = 7,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_portrait_cut/ca/1a/ca1a194c4f3c7cca07779fb2f6d2644d.jpg",
                    PropertyForSaleId = 3
                },
                new PropertyImage
                {
                    Id = 8,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/f7/89/f789ec3ba16848378f6328221121b057.jpg",
                    PropertyForSaleId = 3
                },
                new PropertyImage
                {
                    Id = 9,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/9a/cb/9acb29ab2314046532f9da526346a139.jpg",
                    PropertyForSaleId = 3
                },
                new PropertyImage
                {
                    Id = 10,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/79/b8/79b8792c8f4743428608e021b85494b9.jpg",
                    PropertyForSaleId = 4
                },
                new PropertyImage
                {
                    Id = 11,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/3f/9b/3f9b421dcd930576e05925c7b9ed60a1.jpg",
                    PropertyForSaleId = 4
                },
                new PropertyImage
                {
                    Id = 12,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/92/ea/92ea89763a4237a6637df15827c04e4a.jpg",
                    PropertyForSaleId = 4
                },
                new PropertyImage
                {
                    Id = 13,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/d8/54/d8543df8138af90c3dc5ea3cf32dc9da.jpg",
                    PropertyForSaleId = 5
                },
                new PropertyImage
                {
                    Id = 14,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/70/6c/706c97ac19cac789e2f98c8eecb4ec71.jpg",
                    PropertyForSaleId = 5
                },
                new PropertyImage
                {
                    Id = 15,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/0f/93/0f937c2e81d4a1845ff48840c62ff6a8.jpg",
                    PropertyForSaleId = 5
                },
                new PropertyImage
                {
                    Id = 16,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/7a/21/7a2141072e9c0bc28be6c3d6da5100d5.jpg",
                    PropertyForSaleId = 6
                },
                new PropertyImage
                {
                    Id = 17,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/51/bb/51bb7288f7dcde60e2eb41a5d1fd45cd.jpg",
                    PropertyForSaleId = 6
                },
                new PropertyImage
                {
                    Id = 18,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/fb/3a/fb3ae2895049eca7f9c16503b05cab40.jpg",
                    PropertyForSaleId = 6
                },
                new PropertyImage
                {
                    Id = 19,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/d4/f0/d4f0beabcd7b18c96976129e0202560c.jpg",
                    PropertyForSaleId = 7
                },
                new PropertyImage
                {
                    Id = 20,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/0f/04/0f042421d788be5425596da917424a4f.jpg",
                    PropertyForSaleId = 7
                },
                new PropertyImage
                {
                    Id = 21,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/88/b0/88b0101d3fb67669270c5e8e4e9cd5ac.jpg",
                    PropertyForSaleId = 7
                },
                new PropertyImage
                {
                    Id = 22,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/65/49/65490afef2a1308ae71f6673c7c2c4fb.jpg",
                    PropertyForSaleId = 8
                },
                new PropertyImage
                {
                    Id = 23,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/e4/c4/e4c4fca9793d5b24f7f18ee3dacbc36b.jpg",
                    PropertyForSaleId = 8
                },
                new PropertyImage
                {
                    Id = 24,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/f8/c3/f8c3facbae57fc8cf7f968353ccfad78.jpg",
                    PropertyForSaleId = 8
                },
                new PropertyImage
                {
                    Id = 25,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/30/6c/306c3ea99e55271e62fbd6929ad0aa7a.jpg",
                    PropertyForSaleId = 9
                },
                new PropertyImage
                {
                    Id = 26,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/5a/b6/5ab6d27904bc611421f86acca1ccc3b0.jpg",
                    PropertyForSaleId = 9
                },
                new PropertyImage
                {
                    Id = 27,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/ce/11/ce11059233c17cf7f87566b8b487ddc5.jpg",
                    PropertyForSaleId = 9
                },
                new PropertyImage
                {
                    Id = 28,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/e5/85/e585c94e8d02a3ab282efeae0aeb3159.jpg",
                    PropertyForSaleId = 10
                },
                new PropertyImage
                {
                    Id = 29,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/aa/89/aa893560dccd876332d790c30f21a09f.jpg",
                    PropertyForSaleId = 10
                },
                new PropertyImage
                {
                    Id = 30,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/8d/4b/8d4bcd3ee51bb7094132be5213b5a176.jpg",
                    PropertyForSaleId = 10
                },
                new PropertyImage
                {
                    Id = 31,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/40/de/40de5d03dd09bf4080d38a27ee31879d.jpg",
                    PropertyForSaleId = 11
                },
                new PropertyImage
                {
                    Id = 32,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/4f/b2/4fb28af61b62ebfbf80d29cfdea47f04.jpg",
                    PropertyForSaleId = 11
                },
                new PropertyImage
                {
                    Id = 33,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/25/e5/25e59549eea6a523d399a450bedad7e8.jpg",
                    PropertyForSaleId = 11
                },
                new PropertyImage
                {
                    Id = 34,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/ba/51/ba511339c135aff60088ff6d75b0981d.jpg",
                    PropertyForSaleId = 12
                },
                new PropertyImage
                {
                    Id = 35,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/b2/db/b2dbaff689d60fcfe298217ba59bbb71.jpg",
                    PropertyForSaleId = 12
                },
                new PropertyImage
                {
                    Id = 36,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/43/ef/43ef83bc0e71166110bb5ab84ce7bcb3.jpg",
                    PropertyForSaleId = 12
                },
                new PropertyImage
                {
                    Id = 37,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/13/03/1303775a9171feca8e4266b0da7f6054.jpg",
                    PropertyForSaleId = 14
                },
                new PropertyImage
                {
                    Id = 38,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/c4/62/c4629aa02aad6cee752eba7b14139a18.jpg",
                    PropertyForSaleId = 14
                },
                new PropertyImage
                {
                    Id = 39,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/57/cd/57cdc04e183c17865e8439501d59e349.jpg",
                    PropertyForSaleId = 14
                },
                new PropertyImage
                {
                    Id = 40,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/76/a5/76a52eda3d1e7f0c3891b7802dede629.jpg",
                    PropertyForSaleId = 15
                },
                new PropertyImage
                {
                    Id = 41,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/b4/2f/b42f543bd3090d6464f5d6d9805cbd30.jpg",
                    PropertyForSaleId = 15
                },
                new PropertyImage
                {
                    Id = 42,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/5e/6e/5e6eb2f48b3d357bc924216a54f40852.jpg",
                    PropertyForSaleId = 15
                },
                new PropertyImage
                {
                    Id = 43,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/c3/35/c3356a1e426db8537a6e045923f8e02c.jpg",
                    PropertyForSaleId = 16
                },
                new PropertyImage
                {
                    Id = 44,
                    ImageUrl = "https://bilder.hemnet.se/images/1024x/49/02/49020ae6b62d49631fc776916ec6abf7.jpg",
                    PropertyForSaleId = 16
                },
                new PropertyImage
                {
                    Id = 45,
                    ImageUrl = "https://bilder.hemnet.se/images/1024x/a1/54/a1540769cb5417df8be54afd0bcc0dd9.jpg",
                    PropertyForSaleId = 16
                },
                new PropertyImage
                {
                    Id = 46,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/e2/00/e200c574a8de09cf1f97764b6b0dd130.jpg",
                    PropertyForSaleId = 17
                },
                new PropertyImage
                {
                    Id = 47,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/07/02/07029e6ddb26229039ddd5fa76fb5b8c.jpg",
                    PropertyForSaleId = 17
                },
                new PropertyImage
                {
                    Id = 48,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/88/7a/887a4bc0e4350a475fd39c0bac683c71.jpg",
                    PropertyForSaleId = 17
                },
                new PropertyImage
                {
                    Id = 49,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/6a/09/6a0987081cf8d42daf6a7b21293a4d01.jpg",
                    PropertyForSaleId = 18
                },
                new PropertyImage
                {
                    Id = 50,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/9e/c3/9ec34914afb3f69e278118a9e4e3f105.jpg",
                    PropertyForSaleId = 18
                },
                new PropertyImage
                {
                    Id = 51,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/cc/9c/cc9c15a1c520fa3483d757fe2e87ec9e.jpg",
                    PropertyForSaleId = 18
                },
                new PropertyImage
                {
                    Id = 52,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/3a/a1/3aa161c5fbf2c195c02e969d3c08f8a9.jpg",
                    PropertyForSaleId = 19
                },
                new PropertyImage
                {
                    Id = 53,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/17/c5/17c512c4f0b77ddcc469c177ccc507f6.jpg",
                    PropertyForSaleId = 19
                },
                new PropertyImage
                {
                    Id = 54,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/33/c7/33c7cd2dffcc5fe265bee1b2582b12bb.jpg",
                    PropertyForSaleId = 19
                },
                new PropertyImage
                {
                    Id = 55,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/90/9b/909bb173777f51d64bc2e01f310a8b1a.jpg",
                    PropertyForSaleId = 20
                },
                new PropertyImage
                {
                    Id = 56,
                    ImageUrl = "https://bilder.hemnet.se/images/1024x/1f/c3/1fc3e10be0368d95cfb8d43c7aae611a.jpg",
                    PropertyForSaleId = 20
                },
                new PropertyImage
                {
                    Id = 57,
                    ImageUrl = "https://bilder.hemnet.se/images/1024x/17/90/17901d6115000babb80df084b149e615.jpg",
                    PropertyForSaleId = 20
                },
                new PropertyImage
                {
                    Id = 58,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/c5/86/c58676cf3ebdf4e13163289ff20275e8.jpg",
                    PropertyForSaleId = 13
                },
                new PropertyImage
                {
                    Id = 59,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/c4/26/c426696d7ebd9c382c7754d55324411b.jpg",
                    PropertyForSaleId = 13
                },
                new PropertyImage
                {
                    Id = 60,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/87/cc/87cce528941e3728d37489276de08a97.jpg",
                    PropertyForSaleId = 13
                }
                );
            return builder;
        }

    }
}
