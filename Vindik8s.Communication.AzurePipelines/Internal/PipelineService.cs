using Vindik8s.Communication.AzurePipelines.Abstract;
using Vindik8s.Communication.AzurePipelines.Models;
using Flurl.Http;
using Newtonsoft.Json;

namespace Vindik8s.Communication.AzurePipelines.Internal
{
    internal sealed class PipelineService : IPipelineService
    {
        private readonly IPipelineUriBuilder _uriBuilder;

        public PipelineService(
            IPipelineUriBuilder uriBuilder)
        {
            _uriBuilder = uriBuilder ?? throw new ArgumentNullException(nameof(uriBuilder));
        }

        public async Task TriggerAndApprovePipelineRunAsync()
        {
            var triggerPipelineJson = JsonConvert.SerializeObject(new TriggerPipelinePayload());
            await _uriBuilder.CreateRunsApiUri().PostJsonAsync(triggerPipelineJson);

            var approvePipelineJson = JsonConvert.SerializeObject(new ApprovePipelinePayload());
            await _uriBuilder.CreateApproveRunUri().PatchJsonAsync(approvePipelineJson);
        }
    }
}
