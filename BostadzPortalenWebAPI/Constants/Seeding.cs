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
                        AgencyName = "Gottfridsson",
                        AgencyDescription = "Sveriges näst bästa mäklarbyrå",
                        AgencyLogoUrl = "https://driftservice.blob.core.windows.net/agency-home-solution/5f946ff9-b99b-4e50-96f8-492a34ccbd47_logo",
                        //AgencyRealtors = null
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 2,
                        AgencyName = "Skanebo",
                        AgencyDescription = "Skåne är den bästa platsen på Gotland",
                        AgencyLogoUrl = "https://fatcamp.io/xn--mklare-bua.se/images/artiklar/makl.samfundet.jpg?width=1000",
                        //AgencyRealtors = null
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 3,
                        AgencyName = "Gottfridsson",
                        AgencyDescription = "Sveriges näst bästa mäklarbyrå",
                        AgencyLogoUrl = "BilderKommerSen",
                        AgencyRealtors = null
                    },
                    new RealEstateAgency
                    {
                        RealEstateAgencyId = 4,
                        AgencyName = "Skanebo",
                        AgencyDescription = "Skåne är den bästa platsen på Gotland",
                        AgencyLogoUrl = "BilderKommerSen",
                        AgencyRealtors = null
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
                    AgencyId = 1,
                    PhoneNumber = "0722661920",
                    ProfileImageUrl = "https://genslerzudansdentistry.com/wp-content/uploads/2015/11/anonymous-user.png"

                    //ProfileImageUrl = "NoPicUser.png"
                },
                new Realtor
                {
                    Id = SeedGUID.SystemUser,
                    Email = "user@demoapi.com",
                    NormalizedEmail = "USER@DEMOAPI.COM",
                    UserName = "user@demoapi.com",
                    NormalizedUserName = "USER@DEMOAPI.COM",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 1,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/9b/10/9b10a04e47ec5804594aef06016ceb5b.jpg"
                },
                new Realtor
                {
                    Id = SeedGUID.SystemRealtor,
                    Email = "realtor@demoapi.com",
                    NormalizedEmail = "REALTOR@DEMOAPI.COM",
                    UserName = "realtor@demoapi.com",
                    NormalizedUserName = "REALTOR@DEMOAPI.COM",
                    FirstName = "System",
                    LastName = "Realtor",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    AgencyId = 2,
                    PhoneNumber = "0722661922",
                    ProfileImageUrl = "https://bilder.hemnet.se/images/broker_profile_large/d8/50/d850bd83227eb78f123af53871614efd.jpg"
                }
            );
            return builder;
        }

        public static ModelBuilder IdentityUserRoleBuilder(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = SeedGUID.RoleUser,
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
                }
            );
            return builder;
        }

        public static ModelBuilder MunicipalityBuilder(ModelBuilder builder)
        {
            builder.Entity<Municipality>().HasData(
                new Municipality
                {
                    Id = 1,
                    Name = "Umeå",
                    //PropertiesForSale = null
                },
                 new Municipality
                 {
                     Id = 2,
                     Name = "Stockholm",
                     //PropertiesForSale = null
                 }
                );
            new Municipality
            {
                Id = 2,
                Name = "Stockholm",
                PropertiesForSale = null
            };

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
                    AskingPrice = 500000,
                    MonthlyFee = 5000,
                    YearlyOperatingCost = 1000,
                    LivingArea = 24,
                    PlotArea = 8,
                    SupplementaryArea = 8,
                    YearBuilt = 1999,
                    Address = "Wanker Street 69",
                    Description = "It's a place to live",
                    NumberOfRooms = 1,
                    TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet


                },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 2,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.SystemRealtor,
                     AskingPrice = 1000000,
                     MonthlyFee = 10000,
                     YearlyOperatingCost = 1000,
                     LivingArea = 24,
                     PlotArea = 8,
                     SupplementaryArea = 8,
                     YearBuilt = 1999,
                     Address = "Kungsgatan 4",
                     Description = "Fin utsikt",
                     NumberOfRooms = 1,
                     TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet

                 },
                 new PropertyForSale
                 {
                     PropertyForSaleId = 3,
                     MunicipalityId = 2,
                     RealtorId = SeedGUID.SystemRealtor,
                     AskingPrice = 7000000,
                     MonthlyFee = 10000,
                     YearlyOperatingCost = 1000,
                     LivingArea = 64,
                     PlotArea = 8,
                     SupplementaryArea = 8,
                     YearBuilt = 1950,
                     Address = "Kungsgatan 16",
                     Description = "Bättre än kungsgatan 4",
                     NumberOfRooms = 4,
                     TypeOfProperty = TypeOfPropertyEnum.Villa,

                 }
                );
            new PropertyForSale
            {
                PropertyForSaleId = 2,
                MunicipalityId = 2,
                RealtorId = SeedGUID.SystemRealtor,
                AskingPrice = 1000000,
                MonthlyFee = 10000,
                YearlyOperatingCost = 1000,
                LivingArea = 24,
                PlotArea = 8,
                SupplementaryArea = 8,
                YearBuilt = 1999,
                Address = "Kungsgatan 4",
                Description = "Fin utsikt",
                NumberOfRooms = 1,
                TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet
            };
            new PropertyForSale
            {
                PropertyForSaleId = 3,
                MunicipalityId = 2,
                RealtorId = SeedGUID.SystemRealtor,
                AskingPrice = 7000000,
                MonthlyFee = 10000,
                YearlyOperatingCost = 1000,
                LivingArea = 64,
                PlotArea = 8,
                SupplementaryArea = 8,
                YearBuilt = 1950,
                Address = "Kungsgatan 16",
                Description = "Bättre än kungsgatan 4",
                NumberOfRooms = 4,
                TypeOfProperty = TypeOfPropertyEnum.Villa
            };
        
            return builder;

        }
        public static ModelBuilder SeedPropertyImages(this ModelBuilder builder)
        {
            builder.Entity<PropertyImage>().HasData(
                new PropertyImage
                {
                    Id = 1,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/8c/db/8cdb9b8866cc65d5ec941a56b31ba634.jpg",
                    PropertyForSaleId = 1
                },
                new PropertyImage
                {
                    Id = 2,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/40/f5/40f595711fdb0cc0ebdbd5ee80be8929.jpg",
                    PropertyForSaleId = 2
                },
                new PropertyImage
                {
                    Id = 3,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/89/89/898947735c6b46af72a4556dabadf07a.jpg",
                    PropertyForSaleId = 3
                },
                new PropertyImage
                {
                    Id = 4,
                    ImageUrl = "https://bilder.hemnet.se/images/itemgallery_cut/09/e2/09e29480a003367d9dc3b139de9c416d.jpg",
                    PropertyForSaleId = 1
                },
                new PropertyImage
                {
                    Id = 5,
                    ImageUrl = "https://qasa-static-prod.s3-eu-west-1.amazonaws.com/img/5c5dd162d2ac084603a87e1c8d9f16bd1d93039a57b06ddca34f8aee46e4b88e.jpg",
                    PropertyForSaleId = 2
                },
                new PropertyImage
                {
                    Id = 6,
                    ImageUrl = "https://bcdn.se/images/cache/33121851_960x640.jpg",
                    PropertyForSaleId = 3
                });
            return builder;
        }

    }
}
