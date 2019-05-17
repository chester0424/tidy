using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreMvc_Default.Startups
{
    public class ConfigStartup : IStartup
    {
        public void Configure(IApplicationBuilder app)
        {
            throw new NotImplementedException();
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            throw new NotImplementedException();
        }
    }
}
