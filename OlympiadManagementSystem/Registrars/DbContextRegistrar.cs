using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlympiadManagement.Infrastructure;
using OlympiadManagementSystem.Registrars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Registers
{
    public class DbContextRegistrar : IServiceCollectionRegistrar
    {
 
       
        public void RegisterServices(IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContextFactory<ApplicationDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("Default"),
                b => b.MigrationsAssembly("OlympiadManagement.Infrastructure"))
                );
            //services.AddDbContextFactory<ApplicationDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("Default"),
            //    b => b.MigrationsAssembly("OlympiadManagementSystem")));
        }
    }
}
