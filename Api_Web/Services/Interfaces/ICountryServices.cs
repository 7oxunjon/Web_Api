using Api_Web.DTO;

namespace Api_Web.Services.Interfaces
{
    public interface ICountryServices
    {
         Task<CountryDTO> Insert(CountryDTO country);
    }
}
