using Vindik8s.Communication.AzurePipelines.Abstract;

namespace Vindik8s.Communication.AzurePipelines.Internal
{
    internal sealed class PipelineUriBuilder : IPipelineUriBuilder
    {
        private readonly string _organisation;
        private readonly string _project;
        private readonly int _pipelineId;

        public PipelineUriBuilder()
        {
            // populate above
        }

        public Uri CreateRunsApiUri()
        {
            string uri = $"https://dev.azure.com/{_organisation}/{_project}/_apis/pipelines/{_pipelineId}/runs?api-version={Constants.RunsApi.ApiVersion}";
            return new Uri(uri);
        }

        public Uri CreateApproveRunUri()
        {
            string approvalId = ""; // ?
            string uri = $"https://vsrm.dev.azure.com/{_organisation}/{_project}/_apis/release/approvals/{approvalId}?api-version={Constants.Approvals.ApiVersion}";
            return new Uri(uri);
        }
    }
}
