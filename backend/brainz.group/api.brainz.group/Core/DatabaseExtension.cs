using data.brainz.group.Context;
using Microsoft.EntityFrameworkCore;

namespace api.brainz.group.Core;

public static class DatabaseExtension
{
    public static IServiceCollection AddDatabaseConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("data.brainz.group")
            );
        });

        return services;
    }
}