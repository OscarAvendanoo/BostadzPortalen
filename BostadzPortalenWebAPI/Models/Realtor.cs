using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BostadzPortalenWebAPI.Models
{
    
    //Author: Kevin
    public class Realtor : ApiUser
    {
        
        
        [Display(Name ="Profile Image")]
        public string? ProfileImageUrl { get; set; } // Can be null, use placeholder if so

        [Required]
        public int AgencyId { get; set; }

        public RealEstateAgency Agency { get; set; }


        public virtual List<PropertyForSale> Properties { get; set; }

    }
}
