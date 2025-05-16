using System.Text.Json.Serialization;

namespace BostadzPortalenWebAPI.Models
{
    //author: Ledion
    public class Municipality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<PropertyForSale>? PropertiesForSale { get; set; }
    }
}
