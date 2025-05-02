using BostadzPortalenWebAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BostadzPortalenWebAPI.DTO
{
    //Author: Kevin, Johan Nelin
    public class PropertyForSaleOverviewDTO
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
        public List<PropertyImage> ImageUrls { get; set; } = new List<PropertyImage>();
        public TypeOfPropertyEnum TypeOfProperty { get; set; }
        //public string RealtorId { get; set; }
    }
}

