using Vindik8s.Communication.AzurePipelines.Abstract;
using Vindik8s.Communication.AzurePipelines.Internal;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class Ioc
    {
        public static IServiceCollection AddAzurePipelines(this IServiceCollection services)
        {
            services.AddSingleton<IPipelineService, PipelineService>();
            services.AddSingleton<IPipelineUriBuilder, PipelineUriBuilder>();

            return services;
        }
    }
}
