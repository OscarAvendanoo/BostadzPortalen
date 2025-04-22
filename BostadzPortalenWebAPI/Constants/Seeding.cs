using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BostadzPortalenWebAPI.Constants
{
    //Author: ALL + Johan Nelin (turning it to a static-class instead of in OnModelCreating)
    public static class Seeding
    {
        public static void SeedAll()
        {
            ModelBuilder builder = new ModelBuilder();
            builder = Seeding.IdentityRolesBuilder(builder);
            builder = Seeding.RealEstateAgencyBuilder(builder);
            builder = Seeding.RealtorBuilder(builder);
            builder = Seeding.IdentityUserRoleBuilder(builder);
        }


        public static ModelBuilder IdentityRolesBuilder(ModelBuilder builder)
        {
            //what kind of users should exist
            builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER",
                Id = "e6ae5d04-8f49-4b62-bc52-205353eb08dc"
            },
            new IdentityRole
            {
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
                Id = "e11cc563-5369-471e-9792-6255e0d08eaf"
            },
            new IdentityRole
            {
                Name = "Realtor",
                NormalizedName = "REALTOR",
                Id = "1e346bcf-ee97-4bb2-ab3e-8d7202fea078"
            }
            );
            return builder;
        }

        public static ModelBuilder RealEstateAgencyBuilder(ModelBuilder builder)
        {
            //the real-estate agencies
            builder.Entity<RealEstateAgency>().HasData(
                new RealEstateAgency
                {
                    RealEstateAgencyId = 1,
                    AgencyName = "Gottfridsson",
                    AgencyDescription = "Sveriges näst bästa mäklarbyrå",
                    AgencyLogoUrl = "BilderKommerSen"
                }, 
                new RealEstateAgency
                {
                    RealEstateAgencyId = 2,
                    AgencyName = "Skanebo",
                    AgencyDescription = "Skåne är den bästa platsen på Gotland",
                    AgencyLogoUrl = "BilderKommerSen"
                }
                );
            return builder;
        }

        public static ModelBuilder RealtorBuilder(ModelBuilder builder)
        {
            //the unique users (realtors only)
            builder.Entity<Realtor>().HasData(
                new Realtor
                {

                    Id = "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
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

                    Id = "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
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
                    RoleId = "e6ae5d04-8f49-4b62-bc52-205353eb08dc",
                    UserId = "92b88e50-795f-4df6-90e0-8a7d9a179cb0"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "e11cc563-5369-471e-9792-6255e0d08eaf",
                     UserId = "92d637e6-6a8d-421e-a118-7a29d0edc1e7"
                 }
            );
            return builder;
        }
    }
}
