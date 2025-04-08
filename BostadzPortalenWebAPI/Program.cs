
using BostadzPortalenWebAPI.Data;
using BostadzPortalenWebAPI.Mappings;
using Microsoft.EntityFrameworkCore;

namespace BostadzPortalenWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer(builder.Configuration.GetConnectionString("YourConnectionString"))); //KH

            builder.Services.AddScoped<IRealEstateAgencyRepository, RealEstateAgencyRepository>(); //JN
            builder.Services.AddScoped<IRealtorRepository, RealtorRepository>(); //KH
            builder.Services.AddScoped<IPropertyImageRepository, PropertyImageRepository>(); //Jona

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
