using Vindik8s.Web.Services.Abstract;

namespace Vindik8s.Web.Services.Internal
{
    internal sealed class ClustersService : IClustersService
    {
        public async Task<IReadOnlyCollection<string>> GetClustersAsync()
        {
            return await Task.FromResult(new[] { "c17", "dev", "prod" });
        }
    }
}
