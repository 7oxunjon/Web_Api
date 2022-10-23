using Api_Web.Model;
using Microsoft.EntityFrameworkCore;

namespace Api_Web.Context
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        public DbSet<Country> countries { get; set; }
        public DbSet<Region> regions { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
                builder.Entity<Country>().
                HasMany(p=>p.regions).
                WithOne(p => p.Country).
                HasForeignKey(p => p.CountryId);
        }
    }
}
