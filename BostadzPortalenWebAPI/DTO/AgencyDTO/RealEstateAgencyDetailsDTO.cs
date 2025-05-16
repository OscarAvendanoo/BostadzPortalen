using BostadzPortalenWebAPI.DTO.UserDTO;

namespace BostadzPortalenWebAPI.DTO.AgencyDTO
{
    public class RealEstateAgencyDetailsDTO
    {
        public int RealEstateAgencyId { get; set; }
        public string AgencyName { get; set; } = "";
        public string? AgencyDescription { get; set; } = "";
        public string AgencyLogoUrl { get; set; } = "";
        public List<RealtorAgencyDTO>? RealtorInfo { get; set; }
    }
}
