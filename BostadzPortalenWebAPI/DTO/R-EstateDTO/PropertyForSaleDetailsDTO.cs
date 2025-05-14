using BostadzPortalenWebAPI.Models;
using System.Text.Json.Serialization;

namespace BostadzPortalenWebAPI.DTO
{
    //Author: Johan Nelin
    public class PropertyForSaleDetailsDTO
    {
        public int PropertyForSaleId { get; set; }
        public string Address { get; set; }
        public string MunicipalityName { get; set; }
        public decimal AskingPrice { get; set; }
        public int LivingArea { get; set; } // kvm
        public int SupplementaryArea { get; set; } // kvm
        public int PlotArea { get; set; } // kvm
        public string Description { get; set; }
        public int NumberOfRooms { get; set; }
        public decimal MonthlyFee { get; set; }
        public decimal YearlyOperatingCost { get; set; }
        public int YearBuilt { get; set; }
       
        public List<PropertyImage> ImageUrls { get; set; } = new List<PropertyImage>();
        public TypeOfPropertyEnum TypeOfProperty { get; set; }
        public string PropertyTypeString { get; set; } //for users to be able to read what the Enum is
        public string RealtorFullName { get; set; }
        public string RealtorId { get; set; }
        public string RealtorPicture { get; set; }
        public string AgencyName { get; set; }
        public int AgencyId { get; set; }
        public string AgencyLogo { get; set; }
        public string RealtorEmail { get; set; }
        public string RealtorPhone { get; set; }

        //Might want to add things like (access to: laundry machine / dryer / dishwasher / garage / etc)
    }
}
