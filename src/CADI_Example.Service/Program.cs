namespace CADI_Example.Service
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Serilog;

    /// <summary>
    /// Main Application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main Application Entry Point.
        /// </summary>
        /// <param name="args">Application Arguments.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public static async Task Main(string[] args)
        {
            try
            {
                using var host = CreateHostBuilder(args).Build();
                await host.RunAsync().ConfigureAwait(false);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// IHost Builder.
        /// </summary>
        /// <param name="args">Host Arguments.</param>
        /// <returns>Background Worker Host.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
            => Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((ctx, cfg) =>
                {
                // Uses DOTNET_ENVIRONMENT
                var env = ctx.HostingEnvironment;

                cfg.SetBasePath(ctx.HostingEnvironment.ContentRootPath)
                        // .AddJsonFile("appsettings.Local.json", true, true)
                        ;

                if (args != null)
                    {
                        cfg.AddCommandLine(args);
                    }
                })
                .UseSerilog((ctx, cfg) => cfg.ReadFrom.Configuration(ctx.Configuration))
                .ConfigureLogging((_, log) =>
                {
                    log.AddSerilog();
                    log.AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Warning);
                })
                .UseWindowsService()
                .UseConsoleLifetime()
                .ConfigureServices((ctx, svc) =>
                {
                    ;
                });
    }
}
