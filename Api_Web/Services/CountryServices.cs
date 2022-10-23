using Api_Web.Context;
using Api_Web.Controllers;
using Api_Web.DTO;
using Api_Web.Model;
using Api_Web.Repostory;
using Api_Web.Services.Interfaces;
using AutoMapper;

namespace Api_Web.Services
{
    public class CountryServices : ICountryServices
    {
        protected readonly ICountryRepository repository;
        protected readonly ILogger<CountryController> logger;

        protected readonly IMapper mapper;

        public CountryServices(ICountryRepository repository, ILogger<CountryController> logger, IMapper mapper)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CountryDTO> Insert(CountryDTO countryDTO)
        {
            var country = mapper.Map<Country>(countryDTO);
            
            return mapper.Map<CountryDTO>( await repository.Add(country));
        }
    }
}
