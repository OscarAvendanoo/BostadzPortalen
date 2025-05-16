namespace BostadzPortalenWebAPI.Models
{
    //Author: Johan Nelin
    public class RealEstateAgency
    {
        public int RealEstateAgencyId { get; set; }
        public string AgencyName { get; set; }
        public string AgencyDescription { get; set; }
        public string AgencyLogoUrl { get; set; }
        public virtual List<Realtor>? AgencyRealtors { get; set; } = new List<Realtor>();
    }
}
