using BostadzPortalenClient.Models;

namespace BostadzPortalenClient.Services.Base
{
    public interface IRealtorService
    {
        //Author: Oscar
        Task<Response<Realtor>> GetCurrentRealtor();
    }
}
