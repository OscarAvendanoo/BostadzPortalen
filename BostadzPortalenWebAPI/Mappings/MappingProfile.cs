using AutoMapper;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;

namespace BostadzPortalenWebAPI.Mappings
{
    //Author: Kevin
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Author: Kevin
            CreateMap<Realtor, RegisterRealtorDTO>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.ProfileImageUrl, opt => opt.MapFrom(src => src.ProfileImageUrl))
                .ForMember(dest => dest.AgencyId, opt => opt.MapFrom(src => src.AgencyId))
                .ReverseMap();

            CreateMap<Realtor, RealtorDTO>()
                .ForMember(dest => dest.RealtorId, opt => opt.MapFrom(src => src.RealtorId))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.ProfileImageUrl, opt => opt.MapFrom(src => src.ProfileImageUrl))
                .ForMember(dest => dest.AgencyId, opt => opt.MapFrom(src => src.AgencyId))
                .ForMember(dest => dest.PropertyIds, opt => opt.MapFrom(src => src.Properties.Select(s=>s.PropertyForSaleId)))
                .ReverseMap();

            //Author: Kevin
            CreateMap<PropertyForSale, PropertyForSaleDTO>()
                .ForMember(dest => dest.PropertyForSaleId, opt => opt.MapFrom(src => src.PropertyForSaleId))
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
                .ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => src.Images))
                .ForMember(dest => dest.RealtorId, opt => opt.MapFrom(src => src.RealtorId))
                .ForMember(dest => dest.TypeOfProperty, opt => opt.MapFrom(src => src.TypeOfProperty))
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
              .ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => src.Images))
              .ForMember(dest => dest.RealtorId, opt => opt.MapFrom(src => src.RealtorId))
              .ForMember(dest => dest.TypeOfProperty, opt => opt.MapFrom(src => src.TypeOfProperty))
              .ReverseMap();
        }

    }
}

