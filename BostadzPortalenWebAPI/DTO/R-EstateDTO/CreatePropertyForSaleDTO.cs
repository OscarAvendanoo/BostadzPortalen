using BostadzPortalenWebAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BostadzPortalenWebAPI.DTO
{
    //Author: Oscar
    public class CreatePropertyForSaleDTO
    {       
        public int PropertyForSaleId { get; set; }
        [Required]
        public string Address { get; set; }
        public int MunicipalityId { get; set; }
        [Required]
        public decimal AskingPrice { get; set; }
        [Required]
        public int LivingArea { get; set; } // kvm      
        public int? SupplementaryArea { get; set; } // kvm
        public int PlotArea { get; set; } // kvm
        [Required]
        public string Description { get; set; }
        [Required]
        public int NumberOfRooms { get; set; }
        public decimal MonthlyFee { get; set; }
        [Required]
        public decimal YearlyOperatingCost { get; set; }
        [Required]
        public int YearBuilt { get; set; }
        public List<string> ImageUrls { get; set; } = new List<string>();
        [Required]
        public TypeOfPropertyEnum TypeOfProperty { get; set; }
    }

}

