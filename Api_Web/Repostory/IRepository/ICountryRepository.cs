using Api_Web.Model;

namespace Api_Web.Repostory
{
    public interface ICountryRepository
    {
        Task<Country> Add(Country country);
    }
}
