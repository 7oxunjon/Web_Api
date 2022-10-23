using Api_Web.Repostory;
using Api_Web.Services;
using Api_Web.Services.Interfaces;
using Microsoft.OpenApi.Models;

namespace Api_Web.Extations
{
    public static class MiddlewereExrarioins
    {
        public static void AddServices( this IServiceCollection services)
        {
            services.AddTransient< ICountryServices, CountryServices>();
        }
        
        public static void AddRepostory( this IServiceCollection services)
        {
            services.AddTransient<ICountryRepository, CountryRepository>();
        }

        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = $"Example project APi",
                    Version = $"v1"
                });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then you token in the text input below \r\n\r\nExample:\"Bearer 12345abcdef\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                      new string []{}
                    }
                });
            });
        }
    }
}
