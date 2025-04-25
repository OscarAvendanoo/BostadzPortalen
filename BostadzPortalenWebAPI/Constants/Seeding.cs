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
                    PasswordHash = "AQAAAAIAAYagAAAAEPRrA+z2V4XVE47d6ErGOt4tAuqkN1MIZgNzUM1mFnM8Jw+Mnyi4ddRRngz2mBpIWA==",
                    EmailConfirmed = true,
                    //AgencyId = 1,
                    PhoneNumber = "0722661920"

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
                    PasswordHash = "AQAAAAIAAYagAAAAEFijB/Z0QU8mRE5kfpjArHQDGsgjLMx0GXCljNd3Sg+F/tznlHrQ3+Li6EWmRApXGw==",
                    EmailConfirmed = true,
                    //AgencyId = 1,
                    PhoneNumber = "0722661922"
                },
                new Realtor
                {
                    Id = SeedGUID.HashedUser,
                    Email = "hashed@demoapi.com",
                    NormalizedEmail = "HASHED@DEMOAPI.COM",
                    UserName = "hashed@demoapi.com",
                    NormalizedUserName = "HASHED@DEMOAPI.COM",
                    FirstName = "Hashed",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    EmailConfirmed = true,
                    //AgencyId = 1,
                    PhoneNumber = "0722661922"
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
                     RoleId = SeedGUID.RoleUser,
                     UserId = SeedGUID.HashedUser
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
                }
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
                    AskingPrice = 10000,
                    MonthlyFee = 1000,
                    YearlyOperatingCost = 1000,
                    LivingArea = 24,
                    PlotArea = 8,
                    SupplementaryArea = 8,
                    YearBuilt = 1999,

                }
                );
            return builder;
        }
    }
}
