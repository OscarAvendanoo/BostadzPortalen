using BostadzPortalenWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BostadzPortalenWebAPI.Data.Interface
{
    // Author: Jona
    public interface IPropertyImageRepository : IRepository<PropertyImage>
    {
        Task<PropertyImage> GetPicture(int id);
    }


}
