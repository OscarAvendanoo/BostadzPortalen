using BostadzPortalenClient.Services.Base;
//Author: Johan Nelin

namespace BostadzPortalenClient.DTO
{
    public class PropertyForSaleDetailsDTO
    {
        public int PropertyForSaleId { get; set; }
        public string Address { get; set; }
        public string MunicipalityName { get; set; }
        public decimal AskingPrice { get; set; }
        public int LivingArea { get; set; } // kvm
        public int SupplementaryArea { get; set; } // kvm
        public int PlotArea { get; set; } // kvm
        public string Description { get; set; }
        public int NumberOfRooms { get; set; }
        public decimal MonthlyFee { get; set; }
        public decimal YearlyOperatingCost { get; set; }
        public int YearBuilt { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();
        public TypeOfPropertyEnum TypeOfProperty { get; set; }
        public Realtor Realtor { get; set; }
        public RealEstateAgency RealEstateAgency { get; set; }
    }
}
