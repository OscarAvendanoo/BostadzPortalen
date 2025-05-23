﻿using BostadzPortalenClient.Models;
using BostadzPortalenClient.Services.Base;

namespace BostadzPortalenClient.Services.RealtorSrvc
{
    public interface IRealtorService
    {
        //Author: Oscar
        Task<Response<Realtor>> GetCurrentRealtor();
        Task<Realtor> FindRealtor(string firstName, string lastName);
        Task<RealtorInfoDTO> GetRealtorInfoDTO(string id);
        // Jona
        Task<bool> UpdateRealtorPartialAsync(RealtorUpdateDTO dto);
    }
}
