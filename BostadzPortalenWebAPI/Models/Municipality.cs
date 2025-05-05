namespace BostadzPortalenWebAPI.Models
{
    //author: Ledion
    public class Municipality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // En kommun kan ha flera bostäder
        public virtual List<PropertyForSale>? PropertiesForSale { get; set; }
    }
}
