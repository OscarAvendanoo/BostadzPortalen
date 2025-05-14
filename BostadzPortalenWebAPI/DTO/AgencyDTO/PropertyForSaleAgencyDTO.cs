using BostadzPortalenWebAPI.Models;

namespace BostadzPortalenWebAPI.DTO.AgencyDTO
{
    public class PropertyForSaleAgencyDTO
    {
        public int PropertyForSaleId { get; set; }
        public string Address { get; set; }
        public decimal AskingPrice { get; set; }
        public string FirstImageUrl { get; set; }
        public TypeOfPropertyEnum TypeOfProperty { get; set; }
    }
}
