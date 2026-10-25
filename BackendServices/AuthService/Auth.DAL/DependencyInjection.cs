using Auth.DAL.ApplicationDbContext;
using Auth.DAL.Repositories;
using Auth.DAL.RepositoriesContracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Auth.DAL;

public static class DependencyInjection
{
    public static IServiceCollection AddDAL( this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDBContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}