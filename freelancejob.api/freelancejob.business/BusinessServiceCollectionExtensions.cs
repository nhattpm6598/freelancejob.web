using freelancejob.business.Services;
using freelancejob.business.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using System;

[assembly: CLSCompliant(false)]
namespace Microsoft.Extensions.DependencyInjection
{
    public static class BusinessServiceCollectionExtensions
    {
        /// <summary>
        /// AddSquidex
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>()
                .AddTransient<IConvenantService, ConvenantService>()
                .AddTransient<IJobRequestService, JobRequestService>()
                .AddTransient<IJobService, JobService>()
                .AddTransient<IReportService, ReportService>()
                .AddTransient<ISkillExpertiseService, SkillExpertiseService>()
                .AddTransient<IUserService, UserService>()
                .AddTransient<IUserSkillService, UserSkillService>();

            return services;

        }
    }
}
