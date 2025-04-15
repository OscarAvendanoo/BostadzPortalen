using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BostadzPortalenWebAPI.Data
{
    //Author: Kevin
    public class ApplicationDbContext : IdentityDbContext<ApiUser>
    {
        public DbSet<PropertyForSale> PropertiesForSale { get; set; }
        public DbSet<PropertyImage> PrepertyImages { get; set; }
        public DbSet<RealEstateAgency> RealEstateAgencies { get; set; }
        public DbSet<Realtor> Realtors { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }


        //Kommer inte riktigt ihåg vad vi sa om denna om vi skulle skapa en egen eller om vi skulle hitta på nåt annat.

        /*public DbSet<User> Users { get; set; }*/

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

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
                }
             );
            //var hasher = new PasswordHasher<ApiUser>();
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
                    AgencyId = 1,
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
                    AgencyId = 1,
                    PhoneNumber = "0722661922"
                }
            );

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
        }
    }
   
}

    
