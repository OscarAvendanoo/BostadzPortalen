using BostadzPortalenClient.Models;
using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.MunicipalitySrvc
{
    public interface IMuniService
    {
        //Author: Oscar
        Task<Response<List<Municipality>>> GetAllMunicipalityToListAsync();
    }
}
