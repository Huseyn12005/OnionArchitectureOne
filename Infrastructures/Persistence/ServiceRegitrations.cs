using Application.Repositories;
using Application.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;
using Persistence.UnitOfWorks;

namespace Persistence;

public static class ServiceRegitrations
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfigurationManager configuration)
    {
        services.AddDbContext<AppDbContext>(op => op.UseSqlServer(configuration.GetConnectionString("default")));

        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IGalleryRepository, GalleryRepository>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
