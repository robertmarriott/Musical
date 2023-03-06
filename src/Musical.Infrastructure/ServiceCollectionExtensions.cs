using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Musical.Domain.Repositories;
using Musical.Infrastructure.Persistence;
using Musical.Infrastructure.Persistence.Repositories;

namespace Musical.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MusicalContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

        //services.AddScoped<IArtistRepository, ArtistRepository>();
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        return services;
    }
}
