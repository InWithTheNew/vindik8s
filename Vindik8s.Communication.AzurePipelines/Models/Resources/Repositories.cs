using Newtonsoft.Json;

namespace Vindik8s.Communication.AzurePipelines.Models.Resources
{
    public class Repositories
    {
        [JsonProperty("self")]
        public Self Self { get; set; }
    }
}
