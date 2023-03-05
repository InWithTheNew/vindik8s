namespace Vindik8s.Web.Services.Abstract
{
    public interface IClusterNamespacesService
    {
        Task<IReadOnlyCollection<string>> GetNamespacesAsync(string clusterName);
    }
}
