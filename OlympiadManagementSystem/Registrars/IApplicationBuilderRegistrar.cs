using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Registrars
{
    public interface IApplicationBuilderRegistrar : IRegistrar
    {
        public void RegisterPipelineComponents(IApplicationBuilder app , IWebHostEnvironment env);

    }
}
