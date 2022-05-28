using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlympiadManagementSystem.Registrars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Extensions
{
    public static class RegistrarExtensions
    {
        public static void RegisterServices(this IServiceCollection services , IConfiguration configuration ,Type scanningType)
        {
            var registrars = GetRegistrars<IServiceCollectionRegistrar>(scanningType);
            foreach(var registrar in registrars)
            {
                registrar.RegisterServices(services , configuration);
            }
        }

        public static void RegisterPipelineComponents(this IApplicationBuilder app , IWebHostEnvironment env , Type scanningType)
        {
            var registrars = GetRegistrars<IApplicationBuilderRegistrar>(scanningType);
            foreach (var registrar in registrars)
            {
                registrar.RegisterPipelineComponents(app, env);
            }
        }

        private static IEnumerable<T> GetRegistrars<T>(Type scanningType) where T : IRegistrar
        {
            return scanningType.Assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(T)) && !t.IsAbstract && !t.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<T>();

        }
    }
}
