using freelancejob.business.Services;
using freelancejob.business.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using System;

[assembly: CLSCompliant(false)]
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// addService
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddService(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration is null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            services.AddBusiness();
            services.AddFreelanceJobDataService(configuration);

            return services;
        }

    }
}
