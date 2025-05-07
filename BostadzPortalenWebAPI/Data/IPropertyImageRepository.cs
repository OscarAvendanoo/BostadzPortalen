using BostadzPortalenWebAPI.Models;
using BostadzPortalenWebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace BostadzPortalenWebAPI.Data
{
    // Author: Jona
    public interface IPropertyImageRepository : IRepository<PropertyImage>
    {
        Task<PropertyImage> GetPicture(int id);
    }
        
    
}
