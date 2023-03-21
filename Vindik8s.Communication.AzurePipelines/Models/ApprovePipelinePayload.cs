using Newtonsoft.Json;
using Vindik8s.Communication.AzurePipelines.Internal;

namespace Vindik8s.Communication.AzurePipelines.Models
{
    public class ApprovePipelinePayload
    {
        [JsonProperty("status")]
        public string Status { get; set; } = Constants.Approvals.ApprovalStatuses.Approved;
    }
}
