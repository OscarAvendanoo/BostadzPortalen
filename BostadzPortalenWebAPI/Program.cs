
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

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    b => b.AllowAnyMethod()
                    .AllowAnyOrigin()
                    .AllowAnyHeader());
            });

            builder.Services.AddAutoMapper(typeof(Program)); //KH

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
            });

            builder.Services.AddDbContext<ApplicationDbContext>(options => 

            options.UseSqlServer(builder.Configuration.GetConnectionString("BostadzPortalenWebAPI"))); //KH + JN


            builder.Services.AddScoped<IRealEstateAgencyRepository, RealEstateAgencyRepository>(); //JN
            builder.Services.AddScoped<IRealtorRepository, RealtorRepository>(); //KH
            builder.Services.AddScoped<IPropertyForSaleRepository, PropertyForSaleRepository>(); //OA
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
            app.UseCors("AllowAll");

            app.MapControllers();

            app.Run();
        }
    }
}
