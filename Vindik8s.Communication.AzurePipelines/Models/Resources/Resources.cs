using Newtonsoft.Json;

namespace Vindik8s.Communication.AzurePipelines.Models.Resources
{
    public class Resources
    {
        [JsonProperty("repositories")]
        public Repositories Repositories { get; set; }
    }
}
