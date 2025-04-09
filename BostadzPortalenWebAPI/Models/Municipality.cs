namespace BostadzPortalenWebAPI.Models
{
    public class Municipality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // En kommun kan ha flera bostäder
        public ICollection<PropertyForSale> PropertiesForSale { get; set; }
    }
}
