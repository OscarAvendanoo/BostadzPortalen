using BostadzPortalenWebAPI.Models;

namespace BostadzPortalenWebAPI.DTO
{
    // author Oscar
    public class PropertySearchRequest
    {
       
        public int? TypeOfProperty { get; set; }
        public string MunicipalityName { get; set; }
        public decimal? MinPrice { get; set; }
        
    }
}
