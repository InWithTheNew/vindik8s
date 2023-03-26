using Vindik8s.ClassLibrary;
using Vindik8s.Web.Services.Abstract;

namespace Vindik8s.Web.Services.Internal
{
    internal sealed class ClusterNamespacesService : IClusterNamespacesService
    {
        public async Task<IReadOnlyCollection<string>> GetNamespacesAsync(string clusterName)
        {
            var kubernetesNamespaces = new KubernetesNamespace(clusterName);
            return await kubernetesNamespaces.GetNamespaces();
        }
    }
}
