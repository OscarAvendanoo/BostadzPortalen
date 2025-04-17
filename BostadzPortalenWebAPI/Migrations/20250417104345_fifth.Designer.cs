﻿// <auto-generated />
using System;
using BostadzPortalenWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BostadzPortalenWebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250417104345_fifth")]
    partial class fifth
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("ApiUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.Municipality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Municipalities");
                });

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.PropertyForSale", b =>
                {
                    b.Property<int>("PropertyForSaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyForSaleId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("AskingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<double>("LivingArea")
                        .HasColumnType("float");

                    b.Property<decimal?>("MonthlyFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MunicipalityId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<double?>("PlotArea")
                        .HasColumnType("float");

                    b.Property<string>("RealtorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("SupplementaryArea")
                        .HasColumnType("float");

                    b.Property<int>("TypeOfProperty")
                        .HasColumnType("int");

                    b.Property<int>("YearBuilt")
                        .HasColumnType("int");

                    b.Property<decimal>("YearlyOperatingCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PropertyForSaleId");

                    b.HasIndex("MunicipalityId");

                    b.HasIndex("RealtorId");

                    b.ToTable("PropertiesForSale");
                });

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.PropertyImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyForSaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyForSaleId");

                    b.ToTable("PrepertyImages");
                });

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.RealEstateAgency", b =>
                {
                    b.Property<int>("RealEstateAgencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RealEstateAgencyId"));

                    b.Property<string>("AgencyDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgencyLogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgencyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RealEstateAgencyId");

                    b.ToTable("RealEstateAgencies");

                    b.HasData(
                        new
                        {
                            RealEstateAgencyId = 5,
                            AgencyDescription = "Sveriges näst bästa mäklarbyrå",
                            AgencyLogoUrl = "BilderKommerSen",
                            AgencyName = "Gottfridsson"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e6ae5d04-8f49-4b62-bc52-205353eb08dc",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "e11cc563-5369-471e-9792-6255e0d08eaf",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "1e346bcf-ee97-4bb2-ab3e-8d7202fea078",
                            Name = "Realtor",
                            NormalizedName = "REALTOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                            RoleId = "e6ae5d04-8f49-4b62-bc52-205353eb08dc"
                        },
                        new
                        {
                            UserId = "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                            RoleId = "e11cc563-5369-471e-9792-6255e0d08eaf"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.Realtor", b =>
                {
                    b.HasBaseType("BostadzPortalenWebAPI.Models.ApiUser");

                    b.Property<int?>("AgencyId")
                        .HasColumnType("int");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("AgencyId");

                    b.HasDiscriminator().HasValue("Realtor");

                    b.HasData(
                        new
                        {
                            Id = "92d637e6-6a8d-421e-a118-7a29d0edc1e7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6c0001c4-57fe-422c-824a-0034b304c808",
                            Email = "admin@demoapi.com",
                            EmailConfirmed = true,
                            FirstName = "System",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@DEMOAPI.COM",
                            NormalizedUserName = "ADMIN@DEMOAPI.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPRrA+z2V4XVE47d6ErGOt4tAuqkN1MIZgNzUM1mFnM8Jw+Mnyi4ddRRngz2mBpIWA==",
                            PhoneNumber = "0722661920",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fd3b69c0-c1a4-434d-8ac3-39e53536ea4f",
                            TwoFactorEnabled = false,
                            UserName = "admin@demoapi.com"
                        },
                        new
                        {
                            Id = "92b88e50-795f-4df6-90e0-8a7d9a179cb0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "104e9f83-2a4f-4db9-83e6-b4a6cc5b0d6c",
                            Email = "user@demoapi.com",
                            EmailConfirmed = true,
                            FirstName = "System",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@DEMOAPI.COM",
                            NormalizedUserName = "USER@DEMOAPI.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFijB/Z0QU8mRE5kfpjArHQDGsgjLMx0GXCljNd3Sg+F/tznlHrQ3+Li6EWmRApXGw==",
                            PhoneNumber = "0722661922",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1f2e50c6-467b-48b1-829e-474c7ebdff00",
                            TwoFactorEnabled = false,
                            UserName = "user@demoapi.com"
                        });
                });

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.PropertyForSale", b =>
                {
                    b.HasOne("BostadzPortalenWebAPI.Models.Municipality", "Municipality")
                        .WithMany("PropertiesForSale")
                        .HasForeignKey("MunicipalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BostadzPortalenWebAPI.Models.Realtor", "Realtor")
                        .WithMany("Properties")
                        .HasForeignKey("RealtorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipality");

                    b.Navigation("Realtor");
                });

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.PropertyImage", b =>
                {
                    b.HasOne("BostadzPortalenWebAPI.Models.PropertyForSale", "PropertyForSale")
                        .WithMany("Images")
                        .HasForeignKey("PropertyForSaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PropertyForSale");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BostadzPortalenWebAPI.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BostadzPortalenWebAPI.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BostadzPortalenWebAPI.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BostadzPortalenWebAPI.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.Realtor", b =>
                {
                    b.HasOne("BostadzPortalenWebAPI.Models.RealEstateAgency", "Agency")
                        .WithMany("AgencyRealtors")
                        .HasForeignKey("AgencyId");

                    b.Navigation("Agency");
                });

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.Municipality", b =>
                {
                    b.Navigation("PropertiesForSale");
                });

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.PropertyForSale", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.RealEstateAgency", b =>
                {
                    b.Navigation("AgencyRealtors");
                });

            modelBuilder.Entity("BostadzPortalenWebAPI.Models.Realtor", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
