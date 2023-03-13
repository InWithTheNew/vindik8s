using Vindik8s.ClassLibrary;
using Vindik8s.Web.Services.Abstract;

namespace Vindik8s.Web.Services.Internal
{
    internal sealed class MicroservicesService : IMicroservicesService
    {
        public async Task<IReadOnlyCollection<string>> GetMicroservicesAsync(string clusterName, string namespaceName)
        {
            var Pods = new KubernetesPod(clusterName);

            return await Pods.GetPods(namespaceName);
        }
    }
}
