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
        public int LivingArea { get; set; } // kvm

        public int SupplementaryArea { get; set; } // kvm
        public int PlotArea { get; set; } // kvm

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public int NumberOfRooms { get; set; }

        public decimal MonthlyFee { get; set; }

        [Required]
        public decimal YearlyOperatingCost { get; set; }

        [Required]
        [Range(1900, int.MaxValue, ErrorMessage = "Year must be a valid 4-digit year.")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Year must be a 4-digit number.")]
        public int YearBuilt { get; set; }

        [ForeignKey(nameof(Realtor))]
        public string RealtorId { get; set; }
        public Realtor Realtor { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TypeOfPropertyEnum TypeOfProperty { get; set; }
    }
}
