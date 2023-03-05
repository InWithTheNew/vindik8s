namespace Vindik8s.Web.Services.Abstract
{
    public interface IMicroservicesService
    {
        Task<IReadOnlyCollection<string>> GetMicroservicesAsync(string clusterName, string namespaceName);
    }
}
