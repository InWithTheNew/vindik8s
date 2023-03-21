namespace Vindik8s.Communication.AzurePipelines.Abstract
{
    public interface IPipelineUriBuilder
    {
        Uri CreateRunsApiUri();

        Uri CreateApproveRunUri();
    }
}
