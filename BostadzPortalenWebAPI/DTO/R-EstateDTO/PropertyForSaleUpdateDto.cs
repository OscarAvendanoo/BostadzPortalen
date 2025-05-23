﻿using BostadzPortalenWebAPI.Models;

namespace BostadzPortalenWebAPI.DTO
{

    //Author: Kevin, Oscar
    public class PropertyForSaleUpdateDto
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
        public List<PropertyImageDto> ImageUrls { get; set; } = new List<PropertyImageDto>();
        public TypeOfPropertyEnum TypeOfProperty { get; set; }
        public string PropertyTypeString { get; set; } //for users to be able to read what the Enum is
        public string RealtorFullName { get; set; }
        public string RealtorId { get; set; }
        public string RealtorPicture { get; set; }
        public string AgencyName { get; set; }
        public int AgencyId { get; set; }
        public string AgencyLogo { get; set; }

    }
}
