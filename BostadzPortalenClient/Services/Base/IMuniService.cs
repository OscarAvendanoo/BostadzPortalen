using BostadzPortalenClient.Models;

namespace BostadzPortalenClient.Services.Base
{
    public interface IMuniService
    {
        //Author: Oscar
        Task<Response<List<Municipality>>> GetAllMunicipalityToListAsync();
    }
}
