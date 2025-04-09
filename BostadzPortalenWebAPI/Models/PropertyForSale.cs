using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BostadzPortalenWebAPI.Models
{
    //Author: Oscar Avendano
    public class PropertyForSale
    {
        public int PropertyForSaleId { get; set; }
        [Required]
        public string Address { get; set; }

        [ForeignKey(nameof(Municipality))]
        public int MunicipalityId { get; set; }
        [Required]
        public Municipality Municipality { get; set; }
        [Required]
        public decimal AskingPrice { get; set; }
        [Required]
        public double LivingArea { get; set; } // kvm
        // Extra area som inte är inräknat i levnadsarean men som endå bidrar till värdet på fastigheten
        public double SupplementaryArea { get; set; } // kvm
        // Area av tomt
        public double? PlotArea { get; set; } // kvm
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        public int NumberOfRooms { get; set; }
        // Endast i de fall det finns en månadsavgift, som i bostadsrätter
        public decimal? MonthlyFee { get; set; }
        [Required]
        public decimal YearlyOperatingCost { get; set; }
        [Required]
        [Range(1900, int.MaxValue, ErrorMessage = "Year must be a valid 4-digit year.")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Year must be a 4-digit number.")]
        public int YearBuilt { get; set; }
        public virtual List<PropertyImage> Images { get; set; } = new List<PropertyImage>();
        [ForeignKey(nameof(Realtor))]
        public int RealtorId { get; set; } 
        public Realtor Realtor { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TypeOfPropertyEnum TypeOfProperty { get; set; }
    }
}


