namespace Vindik8s.Web.Services.Abstract
{
    public interface IClustersService
    {
        Task<IReadOnlyCollection<string>> GetClustersAsync();
    }
}
