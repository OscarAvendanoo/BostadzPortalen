using System.Text.Json.Serialization;

namespace BostadzPortalenWebAPI.Models
{
    public class Municipality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // En kommun kan ha flera bostäder
        [JsonIgnore]
        public virtual List<PropertyForSale>? PropertiesForSale { get; set; }
    }
}
