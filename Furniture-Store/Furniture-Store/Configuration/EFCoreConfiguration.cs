
using System;
using FurnitureStore.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace Furniture_Store.Configuration
{
    public static class EFCoreConfiguration
    {
        public static void AddEFCoreInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName))
            );
        }
    }
}

