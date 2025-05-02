using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BostadzPortalenWebAPI.Constants
{
    //Author: ALL + Johan Nelin
    public static class Seeding
    {
        public static ModelBuilder IdentityRolesBuilder(ModelBuilder builder)
        {
            //what kind of users should exist
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
            //the real-estate agencies
            builder.Entity<RealEstateAgency>(t =>
            {
                t.HasData(
                new RealEstateAgency
                {
                    RealEstateAgencyId = 1,
                    AgencyName = "Gottfridsson",
                    AgencyDescription = "Sveriges näst bästa mäklarbyrå",
                    AgencyLogoUrl = "BilderKommerSen",
                    AgencyRealtors = null
                },
                new RealEstateAgency
                {
                    RealEstateAgencyId = 2,
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
            //the hash that's supposed to set the passwords
            var hasher = new PasswordHasher<ApiUser>();

            //the unique users (realtors only)
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
                    ProfileImageUrl = "NoPicUser.png"

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
                    ProfileImageUrl = "NoPicUser.png"
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
                    ProfileImageUrl = "NoPicUser.png"
                }
            );
            return builder;
        }

        public static ModelBuilder IdentityUserRoleBuilder(ModelBuilder builder)
        {
            //tying the unique users to their respective roles
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
                    PropertiesForSale = null
                },
                 new Municipality
                 {
                     Id = 2,
                     Name = "Stockholm",
                     PropertiesForSale = null
                 }
                );
            return builder;
        }
        //public static ModelBuilder PropertyForSaleBuilder(ModelBuilder builder)
        //{
            //builder.Entity<PropertyForSale>().HasData(
            //    new PropertyForSale
            //    {
            //        PropertyForSaleId = 1,
            //        MunicipalityId = 1,
            //        RealtorId = SeedGUID.SystemUser,
            //        AskingPrice = 500000,
            //        MonthlyFee = 5000,
            //        YearlyOperatingCost = 1000,
            //        LivingArea = 24,
            //        PlotArea = 8,
            //        SupplementaryArea = 8,
            //        YearBuilt = 1999,
            //        Address = "Wanker Street 69",
            //        Description = "It's a place to live",
            //        NumberOfRooms = 1,
            //        TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet,
            //        ImageUrls = new List<PropertyImage>
            //        {
            //            new PropertyImage
            //            {
            //                ImageUrl = "https://landsbrovillan.se/media/2028/landsbrovillan_flugeby_039.jpg?width=1000&height=&center=0,5,0,5&mode=crop"
            //            }
            //        }
            //    },
            //     new PropertyForSale
            //     {
            //         PropertyForSaleId = 2,
            //         MunicipalityId = 2,
            //         RealtorId = SeedGUID.SystemRealtor,
            //         AskingPrice = 1000000,
            //         MonthlyFee = 10000,
            //         YearlyOperatingCost = 1000,
            //         LivingArea = 24,
            //         PlotArea = 8,
            //         SupplementaryArea = 8,
            //         YearBuilt = 1999,
            //         Address = "Kungsgatan 4",
            //         Description = "Fin utsikt",
            //         NumberOfRooms = 1,
            //         TypeOfProperty = TypeOfPropertyEnum.Bostadsrättslägenhet,
            //         ImageUrls = new List<PropertyImage>
            //        {
            //            new PropertyImage
            //            {
            //                ImageUrl = "https://landsbrovillan.se/media/2028/landsbrovillan_flugeby_039.jpg?width=1000&height=&center=0,5,0,5&mode=crop"

            //            }
            //        }
            //     },
            //     new PropertyForSale
            //     {
            //         PropertyForSaleId = 3,
            //         MunicipalityId = 2,
            //         RealtorId = SeedGUID.SystemRealtor,
            //         AskingPrice = 7000000,
            //         MonthlyFee = 10000,
            //         YearlyOperatingCost = 1000,
            //         LivingArea = 64,
            //         PlotArea = 8,
            //         SupplementaryArea = 8,
            //         YearBuilt = 1950,
            //         Address = "Kungsgatan 16",
            //         Description = "Bättre än kungsgatan 4",
            //         NumberOfRooms = 4,
            //         TypeOfProperty = TypeOfPropertyEnum.Villa,
            //         ImageUrls = new List<PropertyImage>
            //        {
            //            new PropertyImage
            //            {
            //                ImageUrl = "https://landsbrovillan.se/media/2028/landsbrovillan_flugeby_039.jpg?width=1000&height=&center=0,5,0,5&mode=crop"
            //            }
            //        }
            //     }
            //    );
            //return builder;
        }
    }
//}
