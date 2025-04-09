using BostadzPortalenWebAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace BostadzPortalenWebAPI.Data
{
    //Author: Kevin
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PropertyForSale> PropertiesForSale { get; set; }
        public DbSet<PropertyImage> PrepertyImages { get; set; }
        public DbSet<RealEstateAgency> RealEstateAgencies { get; set; }
        public DbSet<Realtor> Realtors { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }


        //Kommer inte riktigt ihåg vad vi sa om denna om vi skulle skapa en egen eller om vi skulle hitta på nåt annat.

        /*public DbSet<User> Users { get; set; }*/

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
