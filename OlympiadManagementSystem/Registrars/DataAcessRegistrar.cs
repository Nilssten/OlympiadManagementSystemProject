using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlympiadManagement.Application;
using OlympiadManagement.Infrastructure;
using OlympiadManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Registers
{
    public class DataAcessRegistrar : IServiceCollectionRegistrar
    {
        public void RegisterServices(IServiceCollection services , IConfiguration configuration)
        {
            services.AddScoped<IOlympiadRepository, OlympiadDbRepository>();
            services.AddScoped<IOlympiadService, OlympiadService>();
        }
    }
}
