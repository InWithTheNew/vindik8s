using Newtonsoft.Json;

namespace Vindik8s.Communication.AzurePipelines.Models
{
    public class TriggerPipelinePayload
    {
        [JsonProperty("resources")]
        public Resources.Resources Resources { get; set; }

        [JsonProperty("variables")]
        public Variables.Variables Variables { get; set; }
    }
}
