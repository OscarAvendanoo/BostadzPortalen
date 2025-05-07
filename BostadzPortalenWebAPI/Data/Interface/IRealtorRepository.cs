using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BostadzPortalenWebAPI.Data.Interface
{
    //Author: Kevin
    public interface IRealtorRepository : IRepository<Realtor>
    {

        Task<List<Realtor>> GetAllWithIncludesAsync();
        //Task<Realtor> GetByIdIncludesAsync(int id);
        Task<Realtor> GetByNameIncludesAsync(string firstName, string lastName);

        Task<Realtor> GetRealtorByGuidAsync(string guidID);

    }
}