namespace CADI_Example.Application
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using CADI_Example.Domain.Model;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationWorker"/> class.
        /// </summary>
        /// <param name="options">Ioptions</param>
        /// <param name="serviceScopeFactory">Dependency Injection Service Scope.</param>
        public ApplicationWorker(IOptions<CommonOptions> options, IServiceScopeFactory serviceScopeFactory)
        {
            // Create Dependency Injection Scope
            serviceScope = (serviceScopeFactory ?? throw new ArgumentNullException(nameof(serviceScopeFactory))).CreateScope();

        }

        /// <inheritdoc/>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {

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
