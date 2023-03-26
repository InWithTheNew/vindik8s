namespace Vindik8s.ClassLibrary.Models
{
    public class NoviaMicroservice
    {
        public NoviaMicroservice()
        {
            DateCreated = DateTime.UtcNow;
        }

        public NoviaMicroservice(
            string name,
            string pipelineDefinitionId,
            string helmReleaseName)
            : this()
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            PipelineDefinitionId = pipelineDefinitionId ?? throw new ArgumentNullException(nameof(pipelineDefinitionId));
            HelmReleaseName = helmReleaseName ?? throw new ArgumentNullException(nameof(helmReleaseName));
        }

        public string Name { get; set; }

        public string PipelineDefinitionId { get; set; }

        public string HelmReleaseName { get; set; }

        // ?
        public DateTime? DateCreated { get; set; }
    }
}
