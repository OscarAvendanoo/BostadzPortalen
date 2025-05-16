namespace BostadzPortalenWebAPI.DTO.AgencyDTO
{
    public class RealtorAgencyDTO
    {
        public string RealtorId { get; set; }
        public string FullName { get; set; } = "";
        public string? ProfileImageUrl { get; set; }
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public List<PropertyForSaleAgencyDTO> PropertiesForSale { get; set; }
    }
}
