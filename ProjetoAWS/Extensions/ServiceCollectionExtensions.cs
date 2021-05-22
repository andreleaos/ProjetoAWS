using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Security.Principal;
using ProjetoAWS.Main;
using ProjetoAWS.Services.Contracts;
using ProjetoAWS.Services.Impl;
using ProjetoAWS.Repositories.Contracts;
using ProjetoAWS.Repositories.Impl;

namespace ProjetoAWS.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            IConfiguration configuration = GetConfiguration();
            services.AddSingleton<IConfiguration>(configuration);

            AddRepositoryDependencies(services);
            AddServicesDependencies(services);
            AddUtilitesDependencies(services);
            AddAWSServicesDependencies(services);
            AddDatabaseConnectionConfiguration(configuration);

            services.AddSingleton<IAppAWS, AppAWS>();

            return services;
        }

        private static void AddRepositoryDependencies(IServiceCollection services)
        {
            services.AddScoped<IDatabaseRepository, DatabaseRepository>();
        }

        private static void AddServicesDependencies(IServiceCollection services)
        {
            services.AddSingleton<IDatabaseService, DatabaseService>();
        }

        private static void AddUtilitesDependencies(IServiceCollection services)
        {

        }

        private static void AddAWSServicesDependencies(IServiceCollection services)
        {

        }

        private static void AddDatabaseConnectionConfiguration(IConfiguration configuration)
        {

        }

        private static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json")
                .AddEnvironmentVariables();

            var configuration = builder.Build();
            return configuration;
        }
    }
}
