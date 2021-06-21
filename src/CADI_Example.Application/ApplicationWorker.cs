namespace CADI_Example.Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CADI_Example.Domain.Entities;
    using CADI_Example.Domain.Model;
    using CADI_Example.Persistance;
    using CommonFunctionsLib;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Hosting.Internal;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    /// <summary>
    /// Core Application Workder.
    /// </summary>
    public class ApplicationWorker : BackgroundService
    {
        private readonly CommonOptions commonOptions;
        private readonly IServiceScope serviceScope;
        private readonly IHostApplicationLifetime applicationLifetime;
        private readonly ICommonFunctions commonFunctions;
        private readonly SystemDbContext systemDB;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationWorker"/> class.
        /// </summary>
        /// <param name="options">Ioptions.</param>
        /// <param name="serviceScopeFactory">Dependency Injection Service Scope.</param>
        public ApplicationWorker(IOptions<CommonOptions> options, IServiceScopeFactory serviceScopeFactory)
        {
            // Create Dependency Injection Scope
            serviceScope = (serviceScopeFactory ?? throw new ArgumentNullException(nameof(serviceScopeFactory))).CreateScope();

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            commonOptions = options.Value;

            // Configure Application Lifecycle
            applicationLifetime = serviceScope.ServiceProvider.GetRequiredService<IHostApplicationLifetime>();

            commonFunctions = serviceScope.ServiceProvider.GetRequiredService<ICommonFunctions>();

            systemDB = serviceScope.ServiceProvider.GetRequiredService<SystemDbContext>();

            systemDB.Database.EnsureCreated();
            //systemDB.Database.Migrate();


        }

        /// <inheritdoc/>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                // Do work here.

                List<TestData> data = systemDB.TestData.ToList();

                foreach (TestData item in data)
                {
                    Console.WriteLine($"TestDataID {item.TestDataId} Value1 {item.Value1}, Value2 {item.Value2}, Expected {item.ExpectedValue}");
                }
            }
            catch (Exception)
            {
                applicationLifetime.StopApplication();
                throw;
            }

            applicationLifetime.StopApplication();
        }
    }
}
