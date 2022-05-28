using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlympiadManagement.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Registrars
{
    public class DbContextRegistrar : IServiceCollectionRegistrar
    {
 
       
        public void RegisterServices(IServiceCollection services , IConfiguration configuration)
        {

            services.AddDbContextFactory<ApplicationDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("Default"),
    b => b.MigrationsAssembly("OlympiadManagementSystem")));
            services.AddScoped<ApplicationDbContext>(p => p.GetRequiredService<IDbContextFactory<ApplicationDbContext>>().CreateDbContext());
        }
    }
}
