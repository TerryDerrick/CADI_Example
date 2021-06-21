namespace CADI_Example.Persistence
{
    using System;
    using CADI_Example.Persistance;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Handles contextual Depenency Injection.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Connection String name expected in appsettings.json when not otherwise specified.
        /// </summary>
        public const string DefaultConnectionStringName = "DatabaseConnectionString";

        /// <summary>
        /// Adds services to <see cref="IServiceCollection"/> relevant to the Persistance Layer.
        /// </summary>
        /// <param name="services">Service Collection.</param>
        /// <param name="configuration">Configuration.</param>
        /// <param name="connectionStringName">ConnectionString name in application settings.</param>
        /// <returns>Updated Service Collection.</returns>
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services, IConfiguration configuration, string connectionStringName = DefaultConnectionStringName)
        {
            if (configuration is null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            //services.AddDbContext<SystemDbContext>(options => options.UseSqlServer(configuration.GetConnectionString(connectionStringName)));

            // no appsettings yet.
            //services.AddDbContext<SystemDbContext>(options => options.UseInMemoryDatabase(configuration.GetConnectionString(connectionStringName)));
            services.AddDbContext<SystemDbContext>(options => options.UseInMemoryDatabase("TempDatabase"));

            //services.AddScoped<ISystemDbContext>(provider => provider.GetService<SystemDbContext>());

            return services;
        }
    }
}
