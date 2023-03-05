using Vindik8s.Web.Services.Abstract;
using Vindik8s.Web.Services.Internal;

namespace Vindik8s.Web
{
    public static class Ioc
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IClustersService, ClustersService>();
            services.AddSingleton<IClusterNamespacesService, ClusterNamespacesService>();
            services.AddSingleton<IMicroservicesService, MicroservicesService>();
        }
    }
}
