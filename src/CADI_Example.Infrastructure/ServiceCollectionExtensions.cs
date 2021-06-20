using CommonFunctionsLib;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CADI_Example.Infrastructure
{
    /// <summary>
    /// Handles contextual Depenency Injection.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Section name expected in appsettings.json when not otherwise specified.
        /// </summary>
        public const string DefaultSectionName = "AdvancedOptions";

        /// <summary>
        /// Adds services to <see cref="IServiceCollection"/> relevant to the Application Layer.
        /// </summary>
        /// <param name="services">Service Collection.</param>
        /// <param name="configuration">Configuration.</param>
        /// <param name="sectionName">Configuration SectionName for Application.</param>
        /// <returns>Updated Service Collection.</returns>
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration, string sectionName = DefaultSectionName)
        {
            if (configuration is null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            services.AddSingleton<IDateTime, MachineDateTime>();
            services.AddSingleton<ICommonFunctions, CommonFunctions>();

            return services;
        }
    }
}
