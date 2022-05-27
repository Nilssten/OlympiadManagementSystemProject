using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlympiadManagement.Application;
using OlympiadManagement.Application.Repositories;
using OlympiadManagement.Infrastructure;
using OlympiadManagementSystem.Data.Services;
using OlympiadManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Registrars
{
    public class DataAcessRegistrar : IServiceCollectionRegistrar
    {
        public void RegisterServices(IServiceCollection services , IConfiguration configuration)
        {
            services.AddScoped<IOlympiadService, OlympiadService>();
            services.AddScoped<IOlympiadRepository, OlympiadDbRepository>();
            //services.AddScoped<IUserProfileRepository, UserProfileDbRepository>();
            //services.AddScoped<IUserProfileService, UserProfileService>();
        }
    }
}
