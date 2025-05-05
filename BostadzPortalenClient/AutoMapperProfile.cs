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
        }
    }
}
