using BostadzPortalenWebAPI.Constants;
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


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){  }

        //Author: ALL (+ edited Johan Nelin)
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder = Seeding.IdentityRolesBuilder(builder);
            builder = Seeding.RealEstateAgencyBuilder(builder);
            builder = Seeding.RealtorBuilder(builder);
            builder = Seeding.IdentityUserRoleBuilder(builder);

            //the hash that's supposed to set the passwords
            //var hasher = new PasswordHasher<ApiUser>();
        }
    }
}


