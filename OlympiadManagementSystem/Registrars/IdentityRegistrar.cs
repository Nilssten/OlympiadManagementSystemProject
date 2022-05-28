
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlympiadManagement.Infrastructure;
using OlympiadManagement.Infrastructure.IdentityModels;
using OlympiadManagementSystem.Registrars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Registrars
{
    public class IdentityRegistrar : IServiceCollectionRegistrar
    {
        public void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {

            services.AddIdentity<AppUser , AppRole>(options =>
            {

                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;

            })
                .AddEntityFrameworkStores<ApplicationDbContext>();

        }


    }
}