using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Contexts;
using Persistance.Repositories;

namespace Persistance;

public static class PersistanceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddDbContext<BaseDbContext>(opt => opt.UseInMemoryDatabase("rentACars")); --> In Memory için.
        services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("UdemyRentACar")));
        services.AddScoped<IBrandRepository, BrandRepository>();
        services.AddScoped<IModelRepository, ModelRepository>();

        return services;
    }
}
