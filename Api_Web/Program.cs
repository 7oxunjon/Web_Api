
using Api_Web.Context;
using Api_Web.Extations;
using Api_Web.Repostory;
using Api_Web.Services;
using Api_Web.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
Startup(builder.Services, builder.Configuration);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseCors("AllowAll");

app.MapControllers();

app.Run();

static void Startup(IServiceCollection services,ConfigurationManager manager)
{
    services.AddControllers();
    services.AddDbContext<AppDbContext>(p => p.UseNpgsql(manager.GetConnectionString("DefoultContext")));
    services.AddEndpointsApiExplorer();
    services.AddSwagger();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    services.AddServices();
    services.AddRepostory();
    services.AddCors(option =>
    {
        option.AddPolicy("AllowAll", builder =>
        builder.AllowAnyOrigin().
        AllowAnyMethod().AllowAnyHeader());

    });
    
    
}