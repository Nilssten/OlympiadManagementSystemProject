using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Registers
{
    public interface IServiceCollectionRegistrar : IRegistrar
    {
        void RegisterServices(IServiceCollection services , IConfiguration configuration);
    }
}
