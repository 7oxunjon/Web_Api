using Api_Web.DTO;
using Api_Web.Model;
using AutoMapper;

namespace Api_Web.Helper
{
    public class Configuration : Profile
    {
        public Configuration()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
        }
    }
}
