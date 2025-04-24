using BostadzPortalenWebAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace BostadzPortalenWebAPI.DTO
{
    public class CreatePropertyForSaleDTO
    {
        [Required]
        public string Address { get; set; }
        public int MunicipalityId { get; set; }
        [Required]
        public decimal AskingPrice { get; set; }
        [Required]
        public double LivingArea { get; set; } // kvm
        public double? SupplementaryArea { get; set; } // kvm
        public double? PlotArea { get; set; } // kvm
        [Required]
        public string Description { get; set; }
        [Required]
        public int NumberOfRooms { get; set; }
        public decimal? MonthlyFee { get; set; }
        [Required]
        public decimal YearlyOperatingCost { get; set; }
        [Required]
        public int YearBuilt { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();
        [Required]
        public TypeOfPropertyEnum TypeOfProperty { get; set; }
    }
}
