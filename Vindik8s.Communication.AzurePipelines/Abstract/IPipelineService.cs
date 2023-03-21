namespace Vindik8s.Communication.AzurePipelines.Abstract
{
    public interface IPipelineService
    {
        Task TriggerAndApprovePipelineRunAsync();
    }
}
