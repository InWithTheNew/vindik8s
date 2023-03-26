namespace Vindik8s.Web.Services.Abstract
{
    public interface IMicroservicesService
    {
        Task<IReadOnlyCollection<string>> GetInstalledMicroservicesAsync(string clusterName, string namespaceName);

        IReadOnlyCollection<string> GetAllMicroservices(string namespaceName);
    }
}
