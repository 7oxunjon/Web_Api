using Api_Web.Context;
using Api_Web.DTO;
using Api_Web.Helper;
using Api_Web.Model;
using Api_Web.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        protected readonly ICountryServices countryServices;

        public CountryController(ICountryServices countryServices)
        {
            this.countryServices = countryServices ?? throw new ArgumentNullException(nameof(countryServices));
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CountryDTO countryDTO)
        {
            return Ok(await countryServices.Insert(countryDTO));
        }
    }
}
