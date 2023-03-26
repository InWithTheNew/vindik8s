using Microsoft.Extensions.Options;
using Vindik8s.ClassLibrary;
using Vindik8s.ClassLibrary.Models;
using Vindik8s.Web.Services.Abstract;

namespace Vindik8s.Web.Services.Internal
{
    internal sealed class MicroservicesService : IMicroservicesService
    {
        private readonly IList<NoviaMicroservice> _microservices;

        public MicroservicesService(IOptions<List<NoviaMicroservice>> microservices)
        {
            _microservices = microservices?.Value ?? throw new ArgumentNullException(nameof(microservices));
        }

        public async Task<IReadOnlyCollection<string>> GetInstalledMicroservicesAsync(string clusterName, string namespaceName)
        {
            var pods = new KubernetesPod(clusterName);
            return await pods.GetPods(namespaceName);
        }

        public IReadOnlyCollection<string> GetAllMicroservices(string namespaceName)
        {
            return _microservices.Where(w => w.Namespace == namespaceName).Select(s => s.Name).ToList();
        }
    }
}
