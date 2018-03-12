using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace CServi.Hosting
{
    public interface IStartup
    {
        void ConfigureServices(IServiceCollection services);

        void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory,
            IApplicationLifetime applicationLifetime);
    }
}
