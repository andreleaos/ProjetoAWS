using Microsoft.Extensions.DependencyInjection;
using ProjetoAWS.Extensions;
using ProjetoAWS.Main;
using System;
using System.Security.Principal;

namespace ProjetoAWS
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureServices();
        }

        static void ConfigureServices()
        {
            IServiceCollection _serviceCollection = new ServiceCollection();
            _serviceCollection.AddDependencies();
            IServiceProvider serviceProvider = _serviceCollection.BuildServiceProvider();
            var eventService = serviceProvider.GetRequiredService<IAppAWS>();
            eventService.Execute();
          }
    }
}
