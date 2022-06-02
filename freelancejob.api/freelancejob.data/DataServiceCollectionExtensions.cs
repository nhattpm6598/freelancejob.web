using freelancejob.data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

[assembly: CLSCompliant(false)]
namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// ServiceCollectionExtensions
    /// </summary>
    public static class DataServiceCollectionExtensions
    {
        /// <summary>
        /// AddInsightMiddlewareDataService
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddFreelanceJobDataService(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            if (configuration is null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            services.AddDbContextPool<FreelanceJobContext>(option =>
                    option.UseSqlServer(configuration.GetConnectionString("FreelanceJobConnection")));

            return services;
        }
    }
}
