using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Registrars
{
    public class BlazorRegistrar : IServiceCollectionRegistrar
    {
        public void RegisterServices(IServiceCollection services , IConfiguration configuration)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
        }
    }
}
