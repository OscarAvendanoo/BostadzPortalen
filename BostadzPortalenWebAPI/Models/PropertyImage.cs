using System.Text.Json.Serialization;

namespace BostadzPortalenWebAPI.Models
{
    public class PropertyImage
    {
        // Author: Jona
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int? PropertyForSaleId { get; set; }       
        public PropertyForSale? PropertyForSale { get; set; }
    }
}
