using Vindik8s.Web.Services.Abstract;

namespace Vindik8s.Web.Services.Internal
{
    internal sealed class MicroservicesService : IMicroservicesService
    {
        public async Task<IReadOnlyCollection<string>> GetMicroservicesAsync(string clusterName, string namespaceName)
        {
            return await Task.FromResult(new[] { "banking integration scheduler" });
        }
    }
}
