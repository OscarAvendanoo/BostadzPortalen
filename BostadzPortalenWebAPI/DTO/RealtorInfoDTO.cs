namespace BostadzPortalenWebAPI.DTO
{

    //Author: Kevin
    public class RealtorInfoDTO
    {
        public string RealtorId { get; set; } = "";
        public string FullName { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public string AgencyName { get; set; } = "";
        public string RealtorImage { get; set; } = "";
        //Needs to include the Agency-Logo
        //public string AgencyLogo {get; set;} = "";

        //Needs to be Lists, not IEnumerable
        public IEnumerable<PropertyImageDto> PropertyImages { get; set; }
        public IEnumerable<PropertyForSaleOverviewDTO>? Properties { get; set; }

    }
}
