using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace SignalRDemoApp
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(services => services.AddSignalR())
                .Configure(app => app
                    .UseDefaultFiles()
                    .UseStaticFiles()
                    .UseSignalR(routes => routes.MapHub<DefaultHub>("/signalr/default"))
                )
                .Build()
                .Run();
        }
    }
}