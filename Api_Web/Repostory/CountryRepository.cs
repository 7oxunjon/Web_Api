using Api_Web.Context;
using Api_Web.Model;

namespace Api_Web.Repostory
{
    public class CountryRepository : ICountryRepository
    {
        protected readonly AppDbContext dbContext;

        public CountryRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<Country> Add(Country country)
        {
            await dbContext.countries.AddAsync(country);
            await dbContext.SaveChangesAsync();
            return country;
        }
    }
}
