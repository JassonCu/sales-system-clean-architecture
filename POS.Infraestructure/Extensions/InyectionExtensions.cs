using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infraestructure.Persistences.Contexts;
using POS.Infraestructure.Persistences.Interfaces;
using POS.Infraestructure.Persistences.Repositories;

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

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
