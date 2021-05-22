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
            try
            {
                var serviceCollection = ConfigureServices();
                IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
                var eventService = serviceProvider.GetRequiredService<IAppAWS>();
                eventService.Execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static IServiceCollection ConfigureServices()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddDependencies();
            return serviceCollection;
        }
    }
}
