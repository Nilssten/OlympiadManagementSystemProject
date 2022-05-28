using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OlympiadManagement.Application;
using OlympiadManagement.Infrastructure;
using OlympiadManagementSystem.Data;
using OlympiadManagementSystem.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlympiadManagementSystem.Extensions;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using OlympiadManagementSystem.Application.Enums;

namespace OlympiadManagementSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.RegisterServices(Configuration, typeof(Program));
            
            services.AddAuthorization(opt => {
                opt.AddPolicy("SamplePolicy", policy => policy.RequireClaim(ClaimTypes.Role, Roles.ADMIN));
            });


            //This method initializes all roles by adding them to DB and assigning an superadmin 
            //Task.Run(() => RolesInitializer.CreateRoles(services, Configuration)).Wait();
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.RegisterPipelineComponents(env, typeof(Program));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
         
        }

        
    }
}
