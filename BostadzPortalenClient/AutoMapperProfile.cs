using AutoMapper;
using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PropertyForSale, PropertyForSaleOverviewDTO>()
                .ForMember(dest => dest.MunicipalityName, opt => opt.MapFrom(src => src.Municipality.Name))
                .ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => src.ImageUrls))
                .ReverseMap(); 

            CreateMap<PropertyForSale, PropertyForSaleDetailsDTO>()
               .ForMember(dest => dest.MunicipalityName, opt => opt.MapFrom(src => src.Municipality.Name))
               .ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => src.ImageUrls))
               //.ForMember(dest => dest.Realtor, opt => opt.MapFrom(src => src.Realtor.Agency))
               .ReverseMap();

            CreateMap<PropertyForSaleDetailsDTO, PropertyForSaleUpdateDto>()
              .ForMember(dest => dest.PropertyForSaleId, opt => opt.MapFrom(src => src.PropertyForSaleId))
              .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
              .ForMember(dest => dest.RealtorId, opt => opt.MapFrom(src => src.RealtorId))
              .ForMember(dest => dest.RealtorFullName, opt => opt.MapFrom(src => src.RealtorFullName))
              .ForMember(dest => dest.RealtorPicture, opt => opt.MapFrom(src => src.RealtorPicture))
              .ForMember(dest => dest.AgencyId, opt => opt.MapFrom(src => src.AgencyId))
              .ForMember(dest => dest.AgencyLogo, opt => opt.MapFrom(src => src.AgencyLogo))
              .ForMember(dest => dest.AgencyName, opt => opt.MapFrom(src => src.AgencyName))
              .ForMember(dest => dest.MunicipalityName, opt => opt.MapFrom(src => src.MunicipalityName))
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
              .ForMember(dest => dest.PropertyTypeString, opt => opt.MapFrom(src => src.PropertyTypeString))
              .ForMember(dest => dest.YearBuilt, opt => opt.MapFrom(src => src.YearBuilt))
              .ReverseMap();

            CreateMap<PropertyImage, PropertyImageDto>()
            .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.PropertyForSaleId, opt => opt.MapFrom(src => src.PropertyForSaleId));

            CreateMap<RealEstateAgency, RealEstateAgencyDetailsDTO>()
           .ForMember(dest => dest.RealtorInfo, opt => opt.MapFrom(src => src.AgencyRealtors))
           .ReverseMap();
            
           
        }
    }
}
