using Vindik8s.Web.Services.Abstract;
using Vindik8s.ClassLibrary;

namespace Vindik8s.Web.Services.Internal
{
    internal sealed class ClustersService : IClustersService
    {
        public async Task<IReadOnlyCollection<string>> GetClustersAsync()
        {
            var namespaces = new KubernetesClusterOverview();
            return namespaces.GetContexts();
        }
    }
}