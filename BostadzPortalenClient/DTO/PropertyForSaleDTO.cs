using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.DTO
{
    public class PropertyForSaleDTO
    {
        public int PropertyForSaleId { get; set; }
        public string Address { get; set; }
        public string MunicipalityName { get; set; }
        public decimal AskingPrice { get; set; }
        public double LivingArea { get; set; } // kvm
        public double? SupplementaryArea { get; set; } // kvm
        public double? PlotArea { get; set; } // kvm
        public string Description { get; set; }
        public int NumberOfRooms { get; set; }
        public decimal? MonthlyFee { get; set; }
        public decimal YearlyOperatingCost { get; set; }
        public int YearBuilt { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();
        public TypeOfPropertyEnum TypeOfProperty { get; set; }
    }
}
