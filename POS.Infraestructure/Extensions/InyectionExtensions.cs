using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infraestructure.Persistences.Contexts;

namespace POS.Infraestructure.Extensions
{
    public static class InyectionExtensions
    {
        public static IServiceCollection AddInyectionInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(PosContext).FullName;

            services.AddDbContext<PosContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("PosConnection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient
            );

            return services;
        }
    }
}
