using AutoMapper;
using BostadzPortalenWebAPI.DTO;

using BostadzPortalenWebAPI.DTO.R_EstateDTO;

using BostadzPortalenWebAPI.DTO.AgencyDTO;

using BostadzPortalenWebAPI.DTO.UserDTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace BostadzPortalenWebAPI.Mappings
{
    //Author: Kevin, Johan Nelin
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Author: Kevin
            CreateMap<Realtor, RegisterRealtorDTO>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.AgencyId, opt => opt.MapFrom(src => src.AgencyId))
                .ReverseMap();

            CreateMap<Realtor, RealtorDTO>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.ProfileImageUrl, opt => opt.MapFrom(src => src.ProfileImageUrl))
                .ForMember(dest => dest.AgencyId, opt => opt.MapFrom(src => src.AgencyId))
                .ForMember(dest => dest.PropertyIds, opt => opt.MapFrom(src => src.Properties.Select(s=>s.PropertyForSaleId)))
                .ReverseMap();

            //Author: Kevin
            CreateMap<PropertyForSale, PropertyForSaleOverviewDTO>()
                .ForMember(dest => dest.PropertyForSaleId, opt => opt.MapFrom(src => src.PropertyForSaleId))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.MunicipalityName, opt => opt.MapFrom(src => src.Municipality.Name))
                .ForMember(dest => dest.AskingPrice, opt => opt.MapFrom(src => src.AskingPrice))
                .ForMember(dest => dest.LivingArea, opt => opt.MapFrom(src => src.LivingArea))
                .ForMember(dest => dest.SupplementaryArea, opt => opt.MapFrom(src => src.SupplementaryArea))
                .ForMember(dest => dest.PlotArea, opt => opt.MapFrom(src => src.PlotArea))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.NumberOfRooms, opt => opt.MapFrom(src => src.NumberOfRooms))
                .ForMember(dest => dest.MonthlyFee, opt => opt.MapFrom(src => src.MonthlyFee))
                .ForMember(dest => dest.YearlyOperatingCost, opt => opt.MapFrom(src => src.YearlyOperatingCost))
                .ForMember(dest => dest.YearBuilt, opt => opt.MapFrom(src => src.YearBuilt))
                .ForMember(dest => dest.TypeOfProperty, opt => opt.MapFrom(src => src.TypeOfProperty))
                .ForMember(dest => dest.PropertyTypeString, opt => opt.MapFrom(src => src.TypeOfProperty.ToString()))
                .ReverseMap();

            //Author: Johan Nelin
            CreateMap<PropertyForSale, PropertyForSaleDetailsDTO>()
                .ForMember(dest => dest.PropertyForSaleId, opt => opt.MapFrom(src => src.PropertyForSaleId))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src=>src.Address))
                .ForMember(dest => dest.RealtorId, opt => opt.MapFrom(src => src.Realtor.Id))
                .ForMember(dest => dest.RealtorFullName, opt => opt.MapFrom(src => src.Realtor.FirstName + " " + src.Realtor.LastName))
                .ForMember(dest => dest.RealtorPicture, opt => opt.MapFrom(src => src.Realtor.ProfileImageUrl))
                .ForMember(dest => dest.AgencyId, opt => opt.MapFrom(src => src.Realtor.Agency.RealEstateAgencyId))
                .ForMember(dest => dest.AgencyLogo, opt => opt.MapFrom(src => src.Realtor.Agency.AgencyLogoUrl))
                .ForMember(dest => dest.AgencyName, opt => opt.MapFrom(src => src.Realtor.Agency.AgencyName))
                .ForMember(dest => dest.MunicipalityName, opt => opt.MapFrom(src => src.Municipality.Name))
                .ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => src.ImageUrls))
                .ForMember(dest => dest.AskingPrice, opt => opt.MapFrom(src => src.AskingPrice))
                .ForMember(dest => dest.MonthlyFee, opt => opt.MapFrom(src => src.MonthlyFee))
                .ForMember(dest => dest.YearlyOperatingCost, opt => opt.MapFrom(src => src.YearlyOperatingCost))
                .ForMember(dest => dest.LivingArea, opt => opt.MapFrom(src => src.LivingArea))
                .ForMember(dest => dest.PlotArea, opt => opt.MapFrom(src => src.PlotArea))
                .ForMember(dest => dest.SupplementaryArea, opt => opt.MapFrom(src => src.SupplementaryArea))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.NumberOfRooms, opt => opt.MapFrom(src => src.NumberOfRooms))
                .ForMember(dest => dest.PropertyForSaleId, opt => opt.MapFrom(src => src.PropertyForSaleId))
                .ForMember(dest => dest.TypeOfProperty, opt => opt.MapFrom(src => src.TypeOfProperty))
                .ForMember(dest => dest.PropertyTypeString, opt => opt.MapFrom(src => src.TypeOfProperty.ToString()))
                .ForMember(dest => dest.YearBuilt, opt => opt.MapFrom(src => src.YearBuilt))
                .ForMember(dest=>dest.RealtorEmail, opt=>opt.MapFrom(src=>src.Realtor.Email))
                .ForMember(dest => dest.RealtorPhone, opt => opt.MapFrom(src => src.Realtor.PhoneNumber))
                .ReverseMap();

            CreateMap<PropertyForSaleUpdateDto, PropertyForSale>()
             .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
             .ForMember(dest => dest.AskingPrice, opt => opt.MapFrom(src => src.AskingPrice))
             .ForMember(dest => dest.LivingArea, opt => opt.MapFrom(src => src.LivingArea))
             .ForMember(dest => dest.SupplementaryArea, opt => opt.MapFrom(src => src.SupplementaryArea))
             .ForMember(dest => dest.PlotArea, opt => opt.MapFrom(src => src.PlotArea))
             .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
             .ForMember(dest => dest.NumberOfRooms, opt => opt.MapFrom(src => src.NumberOfRooms))
             .ForMember(dest => dest.MonthlyFee, opt => opt.MapFrom(src => src.MonthlyFee))
             .ForMember(dest => dest.YearlyOperatingCost, opt => opt.MapFrom(src => src.YearlyOperatingCost))
             .ForMember(dest => dest.YearBuilt, opt => opt.MapFrom(src => src.YearBuilt))
             .ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => src.ImageUrls))
             .ForMember(dest => dest.TypeOfProperty, opt => opt.MapFrom(src => src.TypeOfProperty))
             .ForMember(dest => dest.RealtorId, opt => opt.MapFrom(src => src.RealtorId))

             // Ignore reverse-mapped properties not sent from client (like navigation props)
             .ForMember(dest => dest.Municipality, opt => opt.Ignore())
             .ForMember(dest => dest.Realtor, opt => opt.Ignore());

            //Author: Kevin, Oscar
            CreateMap<PropertyImage, PropertyImageDto>()
              .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
              .ForMember(dest => dest.PropertyForSaleId, opt => opt.MapFrom(src => src.PropertyForSaleId))
              .ReverseMap();


            CreateMap<PropertyForSale, CreatePropertyForSaleDTO>()
              .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
              .ForMember(dest => dest.MunicipalityId, opt => opt.MapFrom(src => src.MunicipalityId))
              .ForMember(dest => dest.AskingPrice, opt => opt.MapFrom(src => src.AskingPrice))
              .ForMember(dest => dest.LivingArea, opt => opt.MapFrom(src => src.LivingArea))
              .ForMember(dest => dest.SupplementaryArea, opt => opt.MapFrom(src => src.SupplementaryArea))
              .ForMember(dest => dest.PlotArea, opt => opt.MapFrom(src => src.PlotArea))
              .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
              .ForMember(dest => dest.NumberOfRooms, opt => opt.MapFrom(src => src.NumberOfRooms))
              .ForMember(dest => dest.MonthlyFee, opt => opt.MapFrom(src => src.MonthlyFee))
              .ForMember(dest => dest.YearlyOperatingCost, opt => opt.MapFrom(src => src.YearlyOperatingCost))
              .ForMember(dest => dest.YearBuilt, opt => opt.MapFrom(src => src.YearBuilt))
              .ForMember(dest => dest.TypeOfProperty, opt => opt.MapFrom(src => src.TypeOfProperty))
              .ReverseMap();

             CreateMap<CreatePropertyForSaleDTO, PropertyForSale>()
            .ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => src.ImageUrls.Select(url => new PropertyImage { ImageUrl = url }).ToList()))
            .ForMember(dest => dest.RealtorId, opt => opt.Ignore()); // RealtorId is set server-side

            //Author: Kevin
            CreateMap<Realtor, RealtorInfoDTO>()
                .ForMember(dest => dest.RealtorId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.AgencyName, opt => opt.MapFrom(src => src.Agency.AgencyName))
                .ForMember(dest => dest.RealtorImage, opt => opt.MapFrom(src => src.ProfileImageUrl))
                .ForMember(dest => dest.Properties, opt => opt.Ignore())
                .ReverseMap();

            //Author: Oscar
            CreateMap<AgencyDTO, RealEstateAgency>()
                .ForMember(dest => dest.AgencyName, opt => opt.MapFrom(src => src.AgencyName))
                .ForMember(dest => dest.AgencyDescription, opt => opt.MapFrom(src => src.AgencyDescription))
                .ForMember(dest => dest.AgencyLogoUrl, opt => opt.MapFrom(src => src.AgencyLogoUrl))
                .ForMember(dest => dest.AgencyRealtors, opt => opt.Ignore()) // Assuming Realtors are not passed in the DTO
                .ReverseMap();

            CreateMap<RealEstateAgency, RealEstateAgencyDetailsDTO>()
            .ForMember(dest => dest.RealtorInfo, opt => opt.MapFrom(src => src.AgencyRealtors))
            .ReverseMap();

            CreateMap<Realtor, RealtorAgencyDTO>()
                .ForMember(dest=>dest.RealtorId, opt=>opt.MapFrom(src=>src.Id))
                .ForMember(dest=>dest.Phone, opt=>opt.MapFrom(src=>src.PhoneNumber))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.PropertiesForSale, opt => opt.MapFrom(src => src.Properties))
                .ReverseMap();

            CreateMap<PropertyForSale, PropertyForSaleAgencyDTO>()
                .ForMember(dest => dest.FirstImageUrl, opt => opt.MapFrom(src =>
                    src.ImageUrls.FirstOrDefault() != null
                        ? src.ImageUrls.FirstOrDefault().ImageUrl
                        : "/images/property-placeholder.png"))
                .ReverseMap();

        }
    }
}

