using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.DTO
{
    public class PropertyForSaleDTO
    {
        public class PropertyForSaleDto
        {
            public int PropertyForSaleId { get; set; }
            public string Address { get; set; }
            public int MunicipalityId { get; set; }
            public MunicipalityDto Municipality { get; set; }
            public string MunicipalityName { get; set; }
            public decimal AskingPrice { get; set; }
            public int LivingArea { get; set; }
            public int SupplementaryArea { get; set; }
            public int PlotArea { get; set; }
            public string Description { get; set; }
            public int NumberOfRooms { get; set; }
            public decimal MonthlyFee { get; set; }
            public decimal YearlyOperatingCost { get; set; }
            public int YearBuilt { get; set; }
            public List<PropertyImageDto> ImageUrls { get; set; }
            public string RealtorId { get; set; }
            public RealtorDto Realtor { get; set; }
            public string RealtorName { get; set; }
            public int TypeOfProperty { get; set; }
        }
    }
}
