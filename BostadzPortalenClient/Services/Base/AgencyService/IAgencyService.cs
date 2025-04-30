namespace BostadzPortalenClient.Services.Base.AgencyService
{
    public interface IAgencyService
    {
        public Task<IEnumerable<RealEstateAgency>> GetAllAgenciesAsync();
    }
}
