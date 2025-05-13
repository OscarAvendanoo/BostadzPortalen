using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
                        AgencyDescription = "",
                        AgencyLogoUrl = "https://bilder.hemnet.se/images/broker_logo_2_2x/3d/53/3d53972640f121199879bf779e590c7d.jpg"
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 3,
                        AgencyName = "Länsförsäkringar Fastighetsförmedling",
                        AgencyDescription = "",
                        AgencyLogoUrl = "https://bilder.hemnet.se/images/broker_logo_2/73/c6/73c63376473b74a25e13711a82fcae60.png"
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 4,
                        AgencyName = "Svensk Fastighetsförmedling",
                        AgencyDescription = "",
                        AgencyLogoUrl = "https://bilder.hemnet.se/images/broker_logo_2/73/80/7380eae8e412bea23a30d7cdd416f750.png"
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 5,
                        AgencyName = "SkandiaMäklarna",
                        AgencyDescription = "",
                        AgencyLogoUrl = "https://bilder.hemnet.se/images/broker_logo_2_2x/dd/7a/dd7a02fb5c0324de279ace72e14b873c.png"
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 6,
                        AgencyName = "Mäklarhuset",
                        AgencyDescription = "",
                        AgencyLogoUrl = "https://bilder.hemnet.se/images/broker_logo_2_2x/68/41/684184dc02af90e4f9d2ac612122b24f.png"
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 7,
                        AgencyName = "HusmanHagberg",
                        AgencyDescription = "",
                        AgencyLogoUrl = "https://bilder.hemnet.se/images/broker_logo_2_2x/ff/d0/ffd046756118f2684c2df1061d0185c4.png"
                    }
                );
            });
            return builder;
        }


        public static ModelBuilder RealtorBuilder(ModelBuilder builder)
        {
            // Hårdkodad hash för "Test123!"
            //string hash = "AQAAAAEAACcQAAAAEF6oFKaPYv7dY6S49UYErceG71LgqY4NQnl65ID7GEx1UAcL7IeuWnI1fBAGgW6Aow==";

            //Hasher for passwords
            var hasher = new PasswordHasher<Realtor>();

            builder.Entity<Realtor>().HasData(
                new Realtor
                {
                    Id = SeedGUID.SystemAdmin,
                    Email = "admin@demoapi.com",
                    NormalizedEmail = "ADMIN@DEMOAPI.COM",
                    UserName = "admin@demoapi.com",
                    NormalizedUserName = "ADMIN@DEMOAPI.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 1, //keep this as "empty" agency
                    PhoneNumber = "0722661920",
                    ProfileImageUrl = "https://genslerzudansdentistry.com/wp-content/uploads/2015/11/anonymous-user.png"
                },
                new Realtor
                {
                    Id = SeedGUID.SystemUser,
                    Email = "anders.johansson@demoapi.com",
                    NormalizedEmail = "ANDERS.JOHANSSON@DEMOAPI.COM",
                    UserName = "anders.johansson@demoapi.com",
                    NormalizedUserName = "ANDERS.JOHANSSON@DEMOAPI.COM",
                    FirstName = "Anders",
                    LastName = "Johansson",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 2,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/dc/10/dc1096e4429f9ab94cb951c2361c1d2c.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.SystemRealtor,
                    Email = "eric.hultman@demoapi.com",
                    NormalizedEmail = "ERIC.HULTMAN@DEMOAPI.COM",
                    UserName = "eric.hultman@demoapi.com",
                    NormalizedUserName = "ERIC.HULTMAN@DEMOAPI.COM",
                    FirstName = "Eric",
                    LastName = "Hultman",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 2,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/c2/14/c214891aaaaa4cc23e4cbb57a9b95bbd.jpg"
                },
                //FUCKLOADS OF DATA
                new Realtor
                {
                    Id = SeedGUID.Realtor1,
                    Email = "eric.svensson@demoapi.com",
                    NormalizedEmail = "ERIC.SVENSSON@DEMOAPI.COM",
                    UserName = "eric.svensson@demoapi.com",
                    NormalizedUserName = "ERIC.SVENSSON@DEMOAPI.COM",
                    FirstName = "Eric",
                    LastName = "Svensson",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 3,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/28/49/2849c9de29bd992309e8e00aaec96d89.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor2,
                    Email = "christopher.sjodahl@demoapi.com",
                    NormalizedEmail = "CHRISTOPHER.SJODAHL@DEMOAPI.COM",
                    UserName = "christopher.sjodahl@demoapi.com",
                    NormalizedUserName = "CHRISTOPHER.SJODAHL@DEMOAPI.COM",
                    FirstName = "Christopher",
                    LastName = "Sjödahl",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 3,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/7e/0c/7e0ceb545d876de2c344463e3def2b2b.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor3,
                    Email = "asa.danielsson@demoapi.com",
                    NormalizedEmail = "ASA.DANIELSSON@DEMOAPI.COM",
                    UserName = "asa.danielsson@demoapi.com",
                    NormalizedUserName = "ASA.DANIELSSON@DEMOAPI.COM",
                    FirstName = "Åsa",
                    LastName = "Danielsson",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 3,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/93/66/9366e20a447c16f1c7a25c264fe4afba.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor4,
                    Email = "frida.urciuoli@demoapi.com",
                    NormalizedEmail = "FRIDA.URCIUOLI@DEMOAPI.COM",
                    UserName = "frida.urciuoli@demoapi.com",
                    NormalizedUserName = "FRIDA.URCIUOLI@DEMOAPI.COM",
                    FirstName = "Frida",
                    LastName = "Urciuoli",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 4,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/3e/9f/3e9fed971ede79ae8654200a71105a3a.png"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor5,
                    Email = "alf.jonsson@demoapi.com",
                    NormalizedEmail = "ALF.JONSSON@DEMOAPI.COM",
                    UserName = "alf.jonsson@demoapi.com",
                    NormalizedUserName = "ALF.JONSSON@DEMOAPI.COM",
                    FirstName = "Alf",
                    LastName = "Jonsson",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 5,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/fb/e0/fbe05166921e291c40f9d5f22c2403ee.png"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor6,
                    Email = "louise.pedersen@demoapi.com",
                    NormalizedEmail = "LOUISE.PEDERSEN@DEMOAPI.COM",
                    UserName = "louise.pedersen@demoapi.com",
                    NormalizedUserName = "LOUISE.PEDERSEN@DEMOAPI.COM",
                    FirstName = "Louise",
                    LastName = "Pedersen",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 6,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/0d/69/0d69c1adc73cb71ec67c0e48fcd6bf09.png"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor7,
                    Email = "max.hjertqvist@demoapi.com",
                    NormalizedEmail = "MAX.HJERTQVIST@DEMOAPI.COM",
                    UserName = "max.hjertqvist@demoapi.com",
                    NormalizedUserName = "MAX.HJERTQVIST@DEMOAPI.COM",
                    FirstName = "Max",
                    LastName = "Hjertqvist",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 7,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/c3/f1/c3f167f797358d672aa4c1d4b7ffc421.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor8,
                    Email = "garifalia.diakakis@demoapi.com",
                    NormalizedEmail = "GARIFALIA.DIAKAKIS@DEMOAPI.COM",
                    UserName = "garifalia.diakakis@demoapi.com",
                    NormalizedUserName = "GARIFALIA.DIAKAKIS@DEMOAPI.COM",
                    FirstName = "Garifalia",
                    LastName = "Diakakis",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 4,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/9c/a7/9ca77f4a03c12493a14c2acf6400b7db.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor9,
                    Email = "gustav.azelius@demoapi.com",
                    NormalizedEmail = "GUSTAV.AZELIUS@DEMOAPI.COM",
                    UserName = "gustav.azelius@demoapi.com",
                    NormalizedUserName = "GUSTAV.AZELIUS@DEMOAPI.COM",
                    FirstName = "Gustav",
                    LastName = "Azelius",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 5,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/f9/1e/f91ef13e8343b48609d5fc6462fc5b29.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.Realtor10,
                    Email = "tore.wikander@demoapi.com",
                    NormalizedEmail = "TORE.WIKANDER@DEMOAPI.COM",
                    UserName = "tore.wikander@demoapi.com",
                    NormalizedUserName = "TORE.WIKANDER@DEMOAPI.COM",
                    FirstName = "Tore",
                    LastName = "Wikander",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
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
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 21,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor5,
                     AskingPrice = 2395000,
                     MonthlyFee = 4371,
                     YearlyOperatingCost = 2700,
                     LivingArea = 63,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1991,
                     Address = "Smedsgatan 2",
                     Description = "Med centralt läge och promenadavstånd till både stadskärnan och strandpromenaden bor du här i en trivsam vindsvåning med hiss – lugnt placerad högst upp i huset med fönster i tre väderstreck. Den fria utsikten, det generösa ljusinsläppet och de karaktäristiska takkuporna ger hemmet en egen identitet och ett spännande uttryck.\r\n\r\n\r\n\r\nPlanlösningen är lätt att tycka om. Vardagsrum och matplats bildar ett inbjudande rum för både vardag och helg, och köket från Marbodal är välplanerat med bra förvaring och ljusa ytskikt. Från matplatsen når du den rymliga balkongen – en plats för kaffe i morgonsolen likväl som lugna kvällar i dagens sista varma strålar.\r\n\r\n\r\n\r\nSovrummet har ett rofyllt läge och bjuder samtidigt på fin vy över stan – en plats att dra sig tillbaka till men ändå vara nära livet utanför. Badrummet är kaklat, utrustat med badkar och har nyligen uppdaterats med nytt möblemang som ger en fräsch och praktisk känsla. Hallen erbjuder bra med plats för ytterkläder och skor.\r\n\r\n\r\n\r\nHär bor du i en välskött och omtyckt förening med en grön och trivsam innergård – planteringar, utemöbler och en gemensam uteplats bjuder in till avkoppling under sommaren. I källaren finns både tvättstuga och ett förråd som tillhör lägenheten. För dig som får övernattande gäster finns dessutom en gästlägenhet med pentry att hyra för endast 200 kr/natt.\r\n\r\n\r\n\r\nParkeringsplatser under skärmtak finns att tillgå, och läget är centralt men ändå avskilt. Härifrån har du närhet till centrum, älven, gym, Broparken och smidiga bussförbindelser till universitetet, NUS och mycket mer.\r\n\r\n\r\n\r\nVill du bo centralt men ändå lugnt? Då kan det här vara precis vad du letar efter.",
                     NumberOfRooms = 2,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 22,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor6,
                     AskingPrice = 1295000,
                     MonthlyFee = 2636,
                     YearlyOperatingCost = 3156,
                     LivingArea = 35,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 2015,
                     Address = "Alfens allé 15",
                     Description = "Alfens allé 15 - en smart planerad bostad där varje kvadratmeter har en tanke bakom sig. \r\n\r\n\r\n\r\nDenna bostad bjuder på en smart och funktionell planlösning med stilrena och smakfulla materialval. Här hittar du ett fräscht badrum med både tvättmaskin och torktumlare, ett rymligt och flexibelt vardagsrum/sovrum där du kan möblera efter egen smak, samt ett stilfullt kök med moderna vitvaror och en härlig matplats vid fönstret.\r\n\r\n\r\n\r\nFör att verkligen höja vardagslyxen, kan du njuta av den stora altanen som erbjuder perfekt plats för både morgonkaffe och kvällshäng med vänner. \r\n\r\n\r\n\r\nOmrådet kännetecknas av sina gröna omgivningar och utmärkta kommunikationer. Bussen, som stannar alldeles i närheten, tar dig snabbt både till universitetsområdet och till centrala stan. Dessutom bor du med gångavstånd till den populära Nydalasjön med flertalet badplatser, volleybollplan, utegym etc. \r\n\r\n\r\n\r\nVill du bo smart, bekvämt och med en härlig uteplats? Då har du hittat rätt. Varmt välkommen att boka din visning!",
                     NumberOfRooms = 1,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 23,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor6,
                     AskingPrice = 3445000,
                     MonthlyFee = 0,
                     YearlyOperatingCost = 23225,
                     LivingArea = 152,
                     PlotArea = 2659,
                     SupplementaryArea = 0,
                     YearBuilt = 1976,
                     Address = "Ansmark 70",
                     Description = "Här finns nu en riktigt rymlig enplansvilla med hela fyra sovrum och med mycket låga driftskostnader. Fastigheten har en stor tomt och ett naturnära läge samtidigt som det är bekväm närhet till Umeå. Huset värms upp med jordvärme som ger en låg energiförbrukning som möjliggör rabatt på bolåneräntan\r\n\r\n\r\n\r\nIntresserad av den här bostaden? Klicka på knappen läs mer hos mäklaren nedan. Där hittar du mer information och anmäler dig till visning.",
                     NumberOfRooms = 5,
                     TypeOfProperty = TypeOfPropertyEnum.Villa
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 24,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor7,
                     AskingPrice = 2595000,
                     MonthlyFee = 8589,
                     YearlyOperatingCost = 14196,
                     LivingArea = 107,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 2016,
                     Address = "Astronomgatan 5A",
                     Description = "Välkommen till Astronomgatan 5A! \r\n\r\nHär erbjuds en fräsch och modern fyrarumslägenhet i gavelläge med fint ljusinsläpp, påkostad utrustning och öppen planlösning. En mycket fin lägenhet med fräscha ytskikt, stora sällskapsytor och smarta förvaringslösningar. Här är det bara att flytta in och njuta! \r\n\r\nHuset erbjuder alla bekvämligheter med ett modernt boende med vattenburen golvvärme hela bottenplan och tre rymliga sovrum på övre plan och ett entréplan med kök, vardagsrum och en rymlig hall. Dessutom finns här två rymliga badrum som är helt klädd i kakel och klinker.\r\n\r\nTill radhuset hör en uteplats på framsidan av huset med sol nästan hela dagen samt en altan på baksidan av huset med altan.\r\n\r\nTill detta radhus finns en p-plats utanför hus med laddstolpe samt möjlighet att hyra en carportplats med tillhörande förråd.\r\n\r\n\r\n\r\nHär är det lätt för hela familjen att trivas – Äventyrslekpark på promenadavstånd och Nydalasjön en bit bort. På Tavleliden bor du i omtyckta och barnvänliga kvarter. Här finner ni badplats, fina grönområden och förskolor.Ta med familjen och kom på visning!",
                     NumberOfRooms = 4,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättsradhus
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 25,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor7,
                     AskingPrice = 4750000,
                     MonthlyFee = 0,
                     YearlyOperatingCost = 43000,
                     LivingArea = 210,
                     PlotArea = 1099,
                     SupplementaryArea = 90,
                     YearBuilt = 1948,
                     Address = "Backenvägen 117",
                     Description = "På backen finner ni denna rymliga villa med 4 lägenheter varav 1 lägenhet, den största på våning 1 kommer att vara tillgänglig för köparen just nu.\r\n\r\nPå första planet är det 2 st 2.or, på våning 2 är det en 3:a och högst upp en mysig 1.5 rums lägenhet med snedtak.\r\n\r\nHuset har lågt och effektiv drift genom luft/vatten värmepumpar och bra läge nära skolor och kommunikationer. Intäkterna är ca 310 000 per år när allt är uthyrt.\r\n\r\nFör mer information kontakta ansvarig mäklare.",
                     NumberOfRooms = 9,
                     TypeOfProperty = TypeOfPropertyEnum.Villa
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 26,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor8,
                     AskingPrice = 5695000,
                     MonthlyFee = 7114,
                     YearlyOperatingCost = 12960,
                     LivingArea = 112,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1968,
                     Address = "Bygatan 39",
                     Description = "LJUS & RYMLIG BOSTAD -  BALKONG I SÖDERLÄGE - VÄLSKÖTT FÖRENING MED TOPPLÄGE\r\n\r\n\r\n\r\nBOSTADEN\r\n\r\nVälkommen till denna fantastiska bostad med ett av områdets bästa lägen – ett stenkast från Huvudsta Centrum och tunnelbanan, omgiven av grönskande omgivningar. Här erbjuds en välplanerad 112 kvm, som är omgjord till en rymlig femrumslägenhet som känns ännu större än den faktiska ytan. Bostaden håller ett utmärkt skick och ligger högt upp i huset med en solig balkong där du kan njuta av solen under större delen av dagen. Vardagsrummet, som utgör bostadens hjärta, erbjuder gott om plats för socialt umgänge och ger en luftig känsla. Den genomtänkta planlösningen innefattar fyra rymliga sovrum samt goda förvaringsmöjligheter, vilket gör denna bostad perfekt för hela familjen.\r\n\r\n\r\n\r\nFÖRENINGEN\r\n\r\nBRF Bygatan är en stor och stabil bostadsrättsförening med god ekonomi och välskötta fastigheter. Här bor ni i en trygg förening med värdefulla dolda tillgångar om 19 hyresrätter, 3 st lokaler samt med låg belåning om ca 4 042 kr/kvm! Föreningen har vackra och grönskande innergårdar mellan huskropparna, vid Bygatan 25 finns grönskande träd samt en egen boulebana! På andra gårdar finner ni gungor, fontän och annat kul för barn och vuxna. Invid Bygatan finnes Byparken som är en mycket uppskattad lekplats för barnen och ett trevligt ställe att mötas på för de vuxna.\r\n\r\n\r\n\r\nOMRÅDET\r\n\r\nPå Bygatan 39 bor du i en perfekt kombination av citynära bekvämlighet och naturnära livskvalitet! Med Huvudsta Centrum och tunnelbanans blå linje endast en kort promenad bort tar du dig snabbt till City på under 15 minuter – perfekt för både arbete och nöje. Utanför porten hittar du dessutom flera busslinjer och gångavstånd till Solna Centrum med sitt breda utbud av shopping, restauranger och service. I charmiga Huvudsta finns allt du behöver i vardagen. Det renoverade Huvudsta Centrum erbjuder livsmedelsbutiker, apotek, caféer, restauranger, gym och frisör. Behöver du ett större shoppingutbud väntar Mall of Scandinavia, bara tio minuter bort med bil. För resenären är även Arlanda flygplats lättillgänglig via smidiga kommunikationer. För den som värdesätter natur och aktivitet finns det mycket att upptäcka. Bara ett stenkast från bostaden finner du Huvudsta strandbad med badbrygga, omklädningshytter och café, och vill du bada i pool ligger Huvudstabadet med tempererad 50-metersbassäng inom bekvämt avstånd. Strandpromenaden längs Ulvsundasjön bjuder på underbara cykel- och promenadvägar som leder hela vägen in till Hornsbergs strand och Karlbergs slott. Grönområdena är många – från Skytteholmsparkens lekplatser och aktiviteter till de öppna ytorna på Huvudstafältet som bjuder in till träning. Barnfamiljer uppskattar närheten till flera förskolor och skolor, samt den trygga och lugna miljön.",
                     NumberOfRooms = 5,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 27,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor8,
                     AskingPrice = 2395000,
                     MonthlyFee = 2500,
                     YearlyOperatingCost = 6600,
                     LivingArea = 35,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1974,
                     Address = "1:a Huvudstagatan 20",
                     Description = "I trevliga lugna kvarter i Gamla Huvudsta, Solna ligger denna trivsamma och ljusa 1:a i en nybildad bostadsrättsförening. Lägenheten är modernt inredd i absolut toppskick. Lägenheten upplevs ljus och luftig och har en trivsam planlösning. Välplanerad med bl.a. kök, ljust och luftigt vardagsrum med matplats och sovalkov samt praktisk rymlig entréhall och ett smakfullt helkaklat badrum förberett för tvättmaskin.\r\n\r\nLägenheten är centralt belägen i gemytliga Gamla Huvudsta, nära  kvarterskrogar och affärer samt har även närhet till såväl Huvudsta Centrum som till populära Solna Centrum, med stort utbud av butiker och restauranger. I Solna finns även populära Friends arena med både evenemang och shopping.\r\nKnappa tio minuter till fots från bostaden ligger promenadstråken vid Huvudsta strand och Ulvsundasjön. Där det finns pool och friluftsbad, 4-H gård, ridskola, tennisbanor, Pampas Marina samt Karlbergs slott. Det är även nära till mysiga restauranger och badbryggor vid Hornsbergs strand. Området har goda kommunikationer och till Kungsholmen och Vasastan har man dessutom cykelavstånd.\r\n\r\nVälkommen till populära Gamla Huvudsta.\r\n\r\n\r\n\r\n\r\nMer information om lägenhetens nettoskulsättning och föreningens energideklaration är under framtagande.   \r\n\r\nKontakta ansvarig fastighetsmäklare för ytterligare information och bokning av förhandsvisning.",
                     NumberOfRooms = 1,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 28,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor9,
                     AskingPrice = 10500000,
                     MonthlyFee = 0,
                     YearlyOperatingCost = 25752,
                     LivingArea = 277,
                     PlotArea = 732,
                     SupplementaryArea = 90,
                     YearBuilt = 1929,
                     Address = "Bangatan 17",
                     Description = "Välkomna till denna praktfulla och stadsnära sekelskiftsvilla från 20-talet. \r\n\r\nVillan har genomgående renoverats och erbjuder en imponerande boyta på hela 277 kvadratmeter fördelat på tre våningsplan samt en inredd källare på 90 kvadratmeter, garanteras en bekväm och rymlig livsstil för er och er familj.\r\n\r\n\r\n\r\nGenom de generösa fönstren och den härliga takhöjden strömmar naturligt ljus in i varje vrå och skapar en inbjudande och luftig atmosfär. Ni kan njuta av en fantastisk utsikt över den grönskande tomten som ger er både privatliv genom insynsskydd och en naturlig fridfullhet.\r\n\r\n\r\n\r\nBeläget på Bangatan, endast 5 minuter från stadens puls, erbjuder detta hem en oas av skönhet och komfort som väntar på er att utforska. Utöver allt detta erbjuder huset även en separat uthyrningsdel om 51 kvadratmeter, vilket kan erbjuda fler möjligheter och en stadig inkomst.\r\n\r\nGe er själva möjligheten att skapa minnen och uppleva det bästa av sekelskiftets charm och nutidens bekvämligheter.\r\n\r\n\r\n\r\nLåt oss öppna dörrarna till ett hem med ett läge i absoluta världsklass, du är varmt välkommen!",
                     NumberOfRooms = 9,
                     TypeOfProperty = TypeOfPropertyEnum.Villa
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 29,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor9,
                     AskingPrice = 1795000,
                     MonthlyFee = 5178,
                     YearlyOperatingCost = 0,
                     LivingArea = 78,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1970,
                     Address = "Biologigränd 24",
                     Description = "Passa på att lägga vantarna på denna snygga lägenhet! Här hittar du ett stilrent kök som är redo för både vardagsmat och mästerverk, ett fräscht badrum med kakel och klinker, och inte minst – en inglasad balkong i sydväst där du kan njuta av morgonkaffet eller kvällens sista solstrålar, oavsett väder!\r\n\r\n\r\n\r\nLägenheten är stilren med ljusa färger och erbjuder en social planlösning mellan kök och vardagsrum, vilket gör det perfekt för både middagsbjudningar och mysiga hemmakvällar. Plus, det härliga ljusinsläppet ger hela bostaden en extra dos av feel-good. Som bonus finns det också ett rymligt varmförråd bekvämt beläget på samma plan.\r\n\r\n\r\n\r\nOch vad sägs om läget? Biologigränd ligger på Ålidhem, ett superläge vare sig du är student, barnfamilj eller bara vill ha nära till allt. Här är det gångavstånd till både universitetet och sjukhuset, och för den som gillar att röra på sig finns grönområden och IKSU alldeles i närheten. Kommunikationerna är dessutom toppen – du tar dig snabbt och smidigt både in till stan och ut till universitetsområdet.\r\n\r\n\r\n\r\nSom grädde på moset bor du i en bostadsrättsförening som inte bara är aktiv, utan också har riktigt bra ekonomi – här är det tryggt och trivsamt på alla sätt! Föreningen erbjuder dessutom bekvämligheter såsom bastu, gym, pingisrum, tvättstugor, gästlägenhet, festlokal och hobbyrum, vilket gör ditt boende ännu mer komplett och trivsamt.\r\n\r\n\r\n\r\nVälkommen hem!",
                     NumberOfRooms = 3,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 30,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor10,
                     AskingPrice = 2695000,
                     MonthlyFee = 5449,
                     YearlyOperatingCost = 39132,
                     LivingArea = 102,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1901,
                     Address = "Björnbärsvägen 39B",
                     Description = "Välkommen till ett trivsamt och välplanerat hem i två plan med ljusa ytor, genomgående ekparkett och en stor inglasad balkong i soligt läge. Här bor du med egen entré, flera praktiska förvaringslösningar och två helkaklade badrum – perfekt för familjen eller dig som vill ha gott om utrymme.\r\n\r\nEntrén ligger på nedre plan med klinkergolv och golvvärme – en praktisk hall med plats för avhängning. En trappa upp öppnar lägenheten upp sig i en rymlig och möblerbar hall, från vilken du når bostadens alla rum. \r\n\r\nKöket bjuder på vackra skåpluckor i lönn (fågelögon), generösa arbetsytor, gott om förvaring och plats för ett större matbord vid fönstret med utsikt över innergården. Det rymliga vardagsrummet har ett fantastiskt ljusinsläpp och gott om plats för soffgrupp och umgänge.\r\n\r\nLägenheten har tre sovrum, varav två är belägna i en separat sovrumsdel med eget badrum – perfekt för barn, gäster eller hemmakontor. Det större sovrummet har plats för dubbelsäng och förvaring i garderober. Den generösa klädkammaren erbjuder extra förvaring och används idag som snickarbod.\r\n\r\nBåda badrummen är smakfullt inredda med kakel och klinker samt golvvärme, och i det ena finns tvättmaskin/torktumlare för en smidigare vardag. Den inglasade balkongen i bästa söderläge – ett extrarum större delen av året har plats för både loungehörna och middagsbord.\r\n\r\n\r\n\r\nStor, stabil och välskött förening som gjort stora underhåll under åren. Trevliga medlemsförmåner som tvättstugor, samlingslokal med bastu och övernattningsrum för gäster. Gård med fina planteringar, utegrupper och lekplatser. Parkeringsplats med motorvärme finns ledig \r\n\r\n\r\n\r\nBöleäng erbjuder all service som behövs, här bor ni bekvämt nära lekplatser, skola, förskola, fotbollsplaner, Winpos arena, kvartersrestaurangen GKs, välsorterad mataffär och med härlig natur runt husknuten. Aktivt föreningsliv, fina motionsstråk på Bölesholmarna och efter Röbäcksslätten. God kommunikation med buss och cykelavstånd till centrum. Välkommen!",
                     NumberOfRooms = 4,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 31,
                     MunicipalityId = 1,
                     RealtorId = SeedGUID.Realtor10,
                     AskingPrice = 4995000,
                     MonthlyFee = 0,
                     YearlyOperatingCost = 27711,
                     LivingArea = 136,
                     PlotArea = 110,
                     SupplementaryArea = 16,
                     YearBuilt = 1976,
                     Address = "Borgvägen 27E",
                     Description = "Radhus mellan broarna! I idylliska kvarter, på en lugn återvändsgata, har ni nu chansen att förvärva ett riktigt fint gavelradhus! På andra sidan ytterdörren väntar 136 + 16 väldisponerade kvadratmeter som fördelar sig på tre våningsplan. Invändigt kommer ni att uppskatta den perfekt avvägda planlösningen som på entréplan erbjuder sociala ytor i form av kök och vardagsrum samt direktaccess till husets altan och grönyta. På entréplan återfinns även gästtoalett och tvättstuga. En trappa upp är den mer privata sfären som innefattar 4 st sovrum och ett badrum, notera att man låtit bredda dörröppningen till det ena rummet och numera nyttjar det som klädkammare. Två trappor upp finns ett generöst planerat allrum som likväl går att disponera som ett stort sovrum. Förvaring sägs vara något man aldrig kan få för mycket av varpå det bör vara glädjande nyheter när jag berättar att detta våningsplan även inrymmer ett cirka 16 kvm stort förråd!\r\n\r\n\r\n\r\nFör er som har svårt att hålla koll på nycklar kan ni dra en lättnadens suck - dörren har ett digitalt lås (Yale Doorman).\r\n\r\n\r\n\r\n» Genomgående renoverat hus!\r\n\r\n» Förråd i direkt anslutning till ytterdörren. Garageplats i länga + p-plats med motorvärmare.\r\n\r\n\r\n\r\nHär bor ni nära Tegs centrum samt Söderslätts handelsområde med Ikea och Avion. Direkt närhet till förskola/skola, matbutiker, restauranger, ishallen och ett stenkast från älven med dess fina strandpromenad och möjlighet till fiske och bad. Ni har dessutom gång- och cykelavstånd till citykärnan samt goda bussförbindelser till Umeå Universitet och NUS.",
                     NumberOfRooms = 6,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättsradhus
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 32,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor2,
                     AskingPrice = 2500000,
                     MonthlyFee = 2503,
                     YearlyOperatingCost = 0,
                     LivingArea = 32,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1946,
                     Address = "Badstrandsvägen 19",
                     Description = "Välkommen till denna mysiga 1:a med centralt läge på vackra Stora Essingen. Det fria läget med långt till närmsta hus ger bostaden ett härligt ljusinsläpp,  och den väldisponerade planlösningen ger plats för allt du behöver och en flexibel möblering. Det ljusa separata köket har både arbetsyta och god förvaring och här ryms även en mindre matplats. Det helkaklade badrummet är fint renoverat med sobra färger, duschhörna samt handfat med kommod och spegel över. \r\n\r\n\r\n\r\nHär bor du i en välskött bostadsrättsföreningen med mycket god ekonomi och många stora renoveringar utförda. Lägenheten har ett fantastiskt läge med både lugnet på Stora Essingen och gångavstånd både till vattnet med bad och mysiga promenadstråk, samt närhet till Kungsholmens stadspuls. Utanför porten finns busshållplats med bussar som snabbt tar dig in till city. Inom kort gångavstånd finns också restauranger, caféer och matbutik.\r\n\r\n\r\n\r\nMissa inte denna pärla!",
                     NumberOfRooms = 1,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 33,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor3,
                     AskingPrice = 12495000,
                     MonthlyFee = 0,
                     YearlyOperatingCost = 41432,
                     LivingArea = 192,
                     PlotArea = 1570,
                     SupplementaryArea = 36,
                     YearBuilt = 2010,
                     Address = "Badviksvägen 4",
                     Description = "Välkommen till denna rymliga villa på Badviksvägen 4 i Vaxholm, en bostad som erbjuder generösa ytor och modern komfort. Med sina 192 kvadratmeter är huset stort och välplanerat, vilket ger gott om utrymme för hela familjen. Villan har högt i tak, vilket skapar en luftig och ljus atmosfär som genomsyrar hela bostaden.\r\n\r\nDen moderna utrustningen i hemmet säkerställer en bekväm vardag och möter de flesta behov. Bostaden består av fem rum fördelade på en planlösning som är både praktisk och stilfull, perfekt för både sociala tillställningar och avkoppling.\r\n\r\nTomten sträcker sig över imponerande 1570 kvadratmeter och erbjuder en vacker trädgårdstomt, idealisk för utomhusaktiviteter och trädgårdsarbete. Här finner du även en rymlig pool och en vedeldad bastu. För extra boende eller gäster finns ett gästhus på 30 kvadratmeter byggt 2014. Det är utrustat med bergvärmepump som huvudbyggnaden, vilket ger effektiv uppvärmning och miljövänlig energiförbrukning. Den vedeldade badtunnan intill gästhuset ger ytterligare möjligheter till avkoppling året runt.\r\n\r\n\r\nI Vaxholm finns ett brett utbud av badplatser, restauranger, butiker, motionsspår samt förskolor och skolor. Villan ligger i det attraktiva området Resarö, känt för sin natursköna miljö och närhet till vatten. Här får du ett hem där komfort och stil går hand i hand, med en genomtänkt design både inne och ute.  Välkommen att upptäcka ditt nya hem.",
                     NumberOfRooms = 5,
                     TypeOfProperty = TypeOfPropertyEnum.Villa
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 34,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor4,
                     AskingPrice = 3395000,
                     MonthlyFee = 5900,
                     YearlyOperatingCost = 22100,
                     LivingArea = 108,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 2023,
                     Address = "Bagarstugans väg 14",
                     Description = "2 ÅRS AVGIFTSFRITT!\r\nEndast 1 hus kvar! Missa inte möjligheten att förvärva ditt parhus med tillträde omgående eller löpande. Till dig som köper parhus nu bjuder byggherren på avgiften under de första två åren. \r\n\r\nFint planerade parhus med trädgård på både fram-och baksida, plats för två bilar på vardera tomt. Husens baksida vetter mot grönskande allmänning och ligger i bästa söderläge. Genomgående bra standard, ekparkett, vitmålade väggar, gott om förvaring. Öppen härlig planlösning mellan kök och vardagsrum. \r\n\r\n- 1 hus kvar till salu!\r\n- Fint anlagda trädgårdar med baksidan mot söder\r\n- Visningshus finns på plats\r\n- Plats för två bilar på egen tomt\r\n- Stort förråd\r\n- Öppen planlösning\r\n- Avgiftsfritt i två år för att ge ett tryggt köp under dessa tider med förhöjt ränteläge.\r\nDu sparar 141 600 kr på detta sätt. När det gått två år och avgiften ska börjas betalas igen är vi hela vägen framme 2027\r\n\r\n\r\nNu ges chansen att förverkliga drömmen om en modern bostad i en helt unik miljö. I Steninge slottsby uppförs bostadsrättsföreningen Slottets pärla, ett nybyggnadsprojekt om 34 bostäder där vi nu förmedlar de 18 sista parhusen. Här kan ni vänta er en bekväm och fridfull tillvaro, nära till vattnet och den fina naturen. Sigtuna ligger några minuter bort med bil, till både Uppsala och Stockholm tar du dig på 30 minuter och dessutom har du hela världen runt hörnet med 10 minuter till incheckningen på Arlanda. En central plats. Mitt i naturen. I Steninge slottsby har alla bostäder nära till naturen, bad och båtliv i Mälaren, bara några minuter bort. Här skapas en levande plats där butiker, restaurang och naturupplevelser redan finns på plats. Steninge slottsby kommer att bestå av 11 tun, små områden i området, där olika typer av hus och boendeformer blandas. Dina grannar blir barnfamiljer, singelhushåll och par. Vi vill skapa en miljö med liv och rörelse från första stund.",
                     NumberOfRooms = 5,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättsradhus
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 35,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor5,
                     AskingPrice = 2250000,
                     MonthlyFee = 2071,
                     YearlyOperatingCost = 1428,
                     LivingArea = 32,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1954,
                     Address = "Baggebytorget 5",
                     Description = "Välkommen till Baggeby Torget 5! I härliga Baggeby ges chansen att förvärva denna smakfullt renoverade lägenhet med egen ingång. Köket bjuder på stilren minimalism med vita släta fronter och ett rent formspråk. Bra arbetsytor samt fullt utrustat kök med integrerad kyl och frys, induktionshäll, ugn, fläkt samt diskmaskin. Vardagsrummet förenas med köket och matplatsen i en öppen planlösning vilket resulterar i en social yta att inreda med allt från matsalsbord till soffgrupp. Rofyllt sovrum med plats för säng samt tillhörande möblemang. Härifrån når ni även en rymlig walk-in-closet med platsbyggd förvaring. Helkaklat badrum med golvvärme, dusch samt tvättmaskin. Egen uteplats i härligt syd-västläge. \r\n\r\nBaggeby som område är populärt med ett centralt läge på Lidingö, nära bron och bra förbindelser. Lidingöbanan (Baggeby Station) nås på en minut och härifrån når man snabbt Ropsten. I området finns såväl matvarubutik, restauranger och gym vid och runtom Baggeby Torg. Närhet till härliga promenadstråk längs vattnet och härlig natur. ",
                     NumberOfRooms = 2,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 36,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor6,
                     AskingPrice = 2495000,
                     MonthlyFee = 4256,
                     YearlyOperatingCost = 2520,
                     LivingArea = 54,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 2018,
                     Address = "Bergviksgatan 6C",
                     Description = "Drömmer du om att flytta in i ett nytt och modernt hem där alla detaljer redan är på plats? Nu har du chansen! På Bergviksgatan 6C ligger denna fina 2:a som präglas av bland annat öppen samt modern planlösning. Stor terras med härlig vy mot kanalen. Inom gångavstånd väntar Södertäljes stadskärna med sitt utbud av shopping och service. En bostad med närhet till allt! Välkomna!",
                     NumberOfRooms =2,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 37,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor7,
                     AskingPrice = 3995000,
                     MonthlyFee = 3614,
                     YearlyOperatingCost = 8160,
                     LivingArea = 70,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 1984,
                     Address = "Carl Malmstens Väg 2",
                     Description = "NÄRA VATTEN OCH GRÖNSKA - HÄRLIG UTSIKT - STORT BADRUM\r\n\r\n\r\n\r\nLÄGENHETEN\r\n\r\nHär öppnar ni dörren till en välplanerad bostad som passar både familjen och paret. Ett stort fint nyrenoverat kök som bjuder in till härliga middagar. Generöst sovrum med plats för dubbelsäng samt ytterligare ett rum som kan nyttjas som sovrum/ kontor. Sociala ytor och en stor inglasad balkong i västerläge. Bostaden har ett fint renoverat badrum. Mycket goda förvaringsmöjligheter, hel garderobsvägg i hallen samt tillhörande externt förråd.\r\n\r\n\r\n\r\nFÖRENINGEN\r\n\r\nLängs Carl Malmstens väg hittar ni omtyckta och välskötta Brf Fröet 2 i Solna. Husen ligger nära Brunnsvikens strand och är byggda mellan 1983–1985 med god ekonomi. De har bland annat 7 hyresrätter kvar som dolda tillgångar samt två hyresrättslokaler som ger fina hyresintäkter, där verkar populära Restaurangen Who’else samt förskolan Barnens Montessoriakademi. Föreningen har även samlingslokal samt gästlägenhet att nyttja för föreningens medlemmar. Stamspolning skedde i januari 2024 och nya el-platser är driftsatta augusti 2024. En förening med låg belåning och som den senaste tiden amorterat flitigt för att sänka sina räntekostnader.\r\n\r\n\r\n\r\nOMRÅDET\r\n\r\nLägenheten är belägen i södra delen av populära Bergshamra, en mysig oas strax utanför citys sprudlande puls. Här har ni närhet till badbrygga för härliga sommardagar samt Bergshamra Arena där ni kan spela fotboll på sommaren och åka skridskor på vintern. Här får ni det bästa av två världar med närhet till både fina promenadstråk längs vattnet och lummiga grönområden. All typ av service och restaurangutbud endast 10 minuter bort med tunnelbanan. På torget finns bra närservice så som butiker, Apotek samt vårdcentral. Flertalet förskolor och skolor finns också i närområdet. Tunnelbanan och bussar endast ett par minuter från lägenheten och det stora vägnätet nås inom några få minuter.",
                     NumberOfRooms = 2,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 38,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.Realtor8,
                     AskingPrice = 1095000,
                     MonthlyFee = 4191,
                     YearlyOperatingCost = 23592,
                     LivingArea = 47,
                     PlotArea = 0,
                     SupplementaryArea = 0,
                     YearBuilt = 2002,
                     Address = "Centralgatan 7E",
                     Description = "RING FÖR VISNING!\r\n\r\n- Väldisponerad och social lägenhet\r\n\r\n - Tillgång till parkeringsplats\r\n\r\nÖppen planlösning med gott om plats för både soffa och matgrupp, vilket gör det till en idealisk plats för att umgås med familj och vänner. De stora fönstren släpper in rikligt med dagsljus, vilket bidrar till den hemtrevliga känslan. Köket är praktiskt med utmärkta förvaringsmöjligheter och generösa arbetsytor. Här finns även plats för ett matbord och stolar. Badrummet är rymligt och utrustat med allt du behöver: toalett, dusch, handfat, badrumsskåp, förvaringsskåp, tvättmaskin och torktumlare. Sovrummet har ljusa väggar och laminatgolv som ger en lugn och fräsch känsla. Här finns plats för en dubbelsäng och garderober. \r\n\r\nHär bor du vid ett av Märstas bästa lägen med Märsta Centrum inom gångavstånd. Märsta Station ligger endast tio minuter bort och erbjuder utmärkta kommunikationer till både Uppsala och Stockholm. Med allt från matbutiker och restauranger till skolor och vårdcentraler inom bekvämt avstånd, har du allt du behöver nära till hands.\r\n\r\nVarmvattenberedare måste bytas.",
                     NumberOfRooms = 2,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
                 }
                 //,
                 //new PropertyForSale
                 //{
                 //    PropertyForSaleId = ,
                 //    MunicipalityId = ,
                 //    RealtorId = SeedGUID. ,
                 //    AskingPrice = ,
                 //    MonthlyFee = ,
                 //    YearlyOperatingCost = ,
                 //    LivingArea = ,
                 //    PlotArea = ,
                 //    SupplementaryArea = ,
                 //    YearBuilt = ,
                 //    Address = "",
                 //    Description = "",
                 //    NumberOfRooms = ,
                 //    TypeOfProperty = TypeOfPropertyEnum.
                 //}
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
                ,
                new PropertyImage
                {
                    Id = 61,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/c6/39/c639c5edb603c58f1cf363eeee5619be.jpg",
                    PropertyForSaleId = 21
                },
                new PropertyImage
                {
                    Id = 62,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/59/1e/591e4e80af4632dfe5c8ab860fbd45f1.jpg",
                    PropertyForSaleId = 21
                },
                new PropertyImage
                {
                    Id = 63,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/70/28/7028870c12f7285d14097e262d0b11ba.jpg",
                    PropertyForSaleId = 21
                },
                new PropertyImage
                {
                    Id = 64,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/51/d8/51d89c2fdc558268638fe8e827bd39da.jpg",
                    PropertyForSaleId = 23
                },
                new PropertyImage
                {
                    Id = 65,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/58/1b/581bca447be01191a193158fbfd28ae6.jpg",
                    PropertyForSaleId = 23
                },
                new PropertyImage
                {
                    Id = 66,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/ab/5b/ab5bb747a623216afa039e39f80e583f.jpg",
                    PropertyForSaleId = 23
                },
                new PropertyImage
                {
                    Id = 67,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/43/22/43227ecc8e2c3469c0620e940652a4d9.jpg",
                    PropertyForSaleId = 22
                },
                new PropertyImage
                {
                    Id = 68,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/4e/15/4e154ba7f778483af15fdf4ef331116c.jpg",
                    PropertyForSaleId = 22
                },
                new PropertyImage
                {
                    Id = 69,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/dc/43/dc43ac40190a9760ef8fe4c09242f5bd.jpg",
                    PropertyForSaleId = 22
                },
                new PropertyImage
                {
                    Id = 70,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/e4/09/e4093df775d00554630e2d80f3c2e909.jpg",
                    PropertyForSaleId = 24
                },
                new PropertyImage
                {
                    Id = 71,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/53/7e/537eed150d32c5e280c9caae26935110.jpg",
                    PropertyForSaleId = 24
                },
                new PropertyImage
                {
                    Id = 72,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/3d/79/3d79d0fd655376b5e01a23e375cde527.jpg",
                    PropertyForSaleId = 24
                },
                new PropertyImage
                {
                    Id = 73,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/26/c1/26c17eb424f5be636f93615e6efa6841.jpg",
                    PropertyForSaleId = 25
                },
                new PropertyImage
                {
                    Id = 74,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/31/67/3167e33beb2d9cc6c27b355e64a9eae9.jpg",
                    PropertyForSaleId = 25
                },
                new PropertyImage
                {
                    Id = 75,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/34/cb/34cb40b99c014b41f872daa34f1fef4a.jpg",
                    PropertyForSaleId = 25
                },
                new PropertyImage
                {
                    Id = 76,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/96/a0/96a05365ee62c22896f234a83ecd80a1.jpg",
                    PropertyForSaleId = 28
                },
                new PropertyImage
                {
                    Id = 77,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/46/35/46351a59597e87a3fc051c7596440911.jpg",
                    PropertyForSaleId = 28
                },
                new PropertyImage
                {
                    Id = 78,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/1a/eb/1aebd41de1823816c1452534f47c7ea3.jpg",
                    PropertyForSaleId = 28
                },
                new PropertyImage
                {
                    Id = 79,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/b6/a9/b6a93d6694a9e2408b07e0840d5f5706.jpg",
                    PropertyForSaleId = 29
                },
                new PropertyImage
                {
                    Id = 80,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/d3/d4/d3d46b58dfa52c3394776fcfbb6c5bf4.jpg",
                    PropertyForSaleId = 29
                },
                new PropertyImage
                {
                    Id = 81,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/1b/b0/1bb0d84d7a347612319cf3bb36423055.jpg",
                    PropertyForSaleId = 29
                },
                new PropertyImage
                {
                    Id = 82,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/21/31/2131fd8693997a634ccf770f6c67faf6.jpg",
                    PropertyForSaleId = 30
                },
                new PropertyImage
                {
                    Id = 83,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/84/cb/84cbb3402f51bb5ff7a339ed1907569a.jpg",
                    PropertyForSaleId = 30
                },
                new PropertyImage
                {
                    Id = 84,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/2c/3a/2c3aa70a93877387adad2465677e938b.jpg",
                    PropertyForSaleId = 30
                },
                new PropertyImage
                {
                    Id = 85,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/26/cb/26cb505a3b3662e5e2b1fdfb55b8432c.jpg",
                    PropertyForSaleId = 31
                },
                new PropertyImage
                {
                    Id = 86,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/a1/1e/a11e8a09724be5a08585909a9df3c166.jpg",
                    PropertyForSaleId = 31
                },
                new PropertyImage
                {
                    Id = 87,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/ef/2d/ef2d54d42e43cae027da80472a36cf7a.jpg",
                    PropertyForSaleId = 31
                },
                new PropertyImage
                {
                    Id = 88,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/8b/4d/8b4d68bdd448fc8f4c4fb60c438b20a6.jpg",
                    PropertyForSaleId = 26
                },
                new PropertyImage
                {
                    Id = 89,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/3d/cf/3dcf94429f220e92f8f6c9568eb9cec5.jpg",
                    PropertyForSaleId = 26
                },
                new PropertyImage
                {
                    Id = 90,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/4d/af/4dafc6611321e4c8595d5b7eaa85ca45.jpg",
                    PropertyForSaleId = 26
                },
                new PropertyImage
                {
                    Id = 91,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/96/16/9616eaf912e8032c4317dc02878cc84c.jpg",
                    PropertyForSaleId = 27
                },
                new PropertyImage
                {
                    Id = 92,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/17/a5/17a5f05e8b849551315dcc52a952284c.jpg",
                    PropertyForSaleId = 27
                },
                new PropertyImage
                {
                    Id = 93,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_portrait_cut/0b/0a/0b0a1964936eb97c18d614f553f3fb12.jpg",
                    PropertyForSaleId = 27
                },
                new PropertyImage
                {
                    Id = 94,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/9f/e7/9fe7391814d38b2d7f3bba22ba2d124d.jpg",
                    PropertyForSaleId = 32
                },
                new PropertyImage
                {
                    Id = 95,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/c8/a6/c8a67bbf2e4dff1b565df2e72dbfbbf9.jpg",
                    PropertyForSaleId = 32
                },
                new PropertyImage
                {
                    Id = 96,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/a7/d8/a7d89b16676ea8c4dc89f5caae01a30d.jpg",
                    PropertyForSaleId = 32
                },
                new PropertyImage
                {
                    Id = 97,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/60/9b/609b9b038e2c989dd3a25e1022540238.jpg",
                    PropertyForSaleId = 33
                },
                new PropertyImage
                {
                    Id = 98,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/22/ef/22efa45ab97ec57677ad49b2d7d420a4.jpg",
                    PropertyForSaleId = 33
                },
                new PropertyImage
                {
                    Id = 99,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/36/80/368007d32471d1bc7bfa7bfe99527e93.jpg",
                    PropertyForSaleId = 33
                },
                new PropertyImage
                {
                    Id = 100,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/4d/c9/4dc990dd72ba3a59a3eadd00786a70c8.jpg",
                    PropertyForSaleId = 34
                },
                new PropertyImage
                {
                    Id = 101,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/d5/89/d589471444bd80f855930a6c0abdc892.jpg",
                    PropertyForSaleId = 34
                },
                new PropertyImage
                {
                    Id = 102,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/0e/ef/0eef32b870baf7bc9d304226f7aefa30.jpg",
                    PropertyForSaleId = 34
                },
                new PropertyImage
                {
                    Id = 103,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/e3/81/e381e176bdf34a38843ecd69319a2e48.jpg",
                    PropertyForSaleId =35
                },
                new PropertyImage
                {
                    Id = 104,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/fc/1e/fc1e93d5ce220604aaa72b7b094cdf15.jpg",
                    PropertyForSaleId =35
                },
                new PropertyImage
                {
                    Id = 105,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/67/34/673479f16d42745c0144d050c39891e7.jpg",
                    PropertyForSaleId =35
                },
                new PropertyImage
                {
                    Id = 106,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/50/6b/506be80937d96a80bc2e35e52671c488.jpg",
                    PropertyForSaleId =36
                },
                new PropertyImage
                {
                    Id = 107,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/04/9b/049b84c90c065cdd3214309e22839717.jpg",
                    PropertyForSaleId =36
                },
                new PropertyImage
                {
                    Id = 108,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/f5/5b/f55bad611848c2d0ebfd8b2faf56eaff.jpg",
                    PropertyForSaleId =36
                },
                new PropertyImage
                {
                    Id = 109,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/6a/d2/6ad2fb06593d538eeaa121e1daddf635.jpg",
                    PropertyForSaleId =37
                },
                new PropertyImage
                {
                    Id = 110,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/9c/b8/9cb8afef913e44c125a225edbfc584d3.jpg",
                    PropertyForSaleId =37
                },
                new PropertyImage
                {
                    Id = 111,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/5c/38/5c3877ce6761f98062f3d5b4e4c35bd0.jpg",
                    PropertyForSaleId =37
                },
                new PropertyImage
                {
                    Id = 112,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/6d/fe/6dfe21fb098a0913845232e3f8ef7183.jpg",
                    PropertyForSaleId =38
                },
                new PropertyImage
                {
                    Id = 113,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/39/66/39661759db61a12718ab82914f0c63ca.jpg",
                    PropertyForSaleId =38
                },
                new PropertyImage
                {
                    Id = 114,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/82/70/82701bcadcefb55d340a2fbb3db72c73.jpg",
                    PropertyForSaleId =38
                }
                //,
                //new PropertyImage
                //{
                //    Id = ,
                //    ImageUrl = "",
                //    PropertyForSaleId =
                //}
                );
            return builder;
        }

    }
}
