using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BostadzPortalenWebAPI.Data
{
    //Author: Kevin
    public interface IRealtorRepository : IRepository<Realtor>
    {
        public Task<IEnumerable<PropertyForSale>> GetListedPropertiesAsync(int id);

        //public Task AddPropertyForSale(PropertyForSale propertyForSale);

        //public Task<PropertyForSale> EditPropertyForSale(PropertyForSale propertyForSale);


    }
}