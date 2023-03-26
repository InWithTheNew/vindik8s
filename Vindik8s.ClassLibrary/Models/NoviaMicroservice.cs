namespace Vindik8s.ClassLibrary.Models
{
    public class NoviaMicroservice
    {
        public NoviaMicroservice()
        {
        }

        public NoviaMicroservice(
            string name,
            string namespacee,
            string pipelineDefinitionId,
            string helmReleaseName)
            : this()
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Namespace = namespacee ?? throw new ArgumentNullException(nameof(namespacee));
            PipelineDefinitionId = pipelineDefinitionId ?? throw new ArgumentNullException(nameof(pipelineDefinitionId));
            HelmReleaseName = helmReleaseName ?? throw new ArgumentNullException(nameof(helmReleaseName));
        }

        public string Name { get; set; }

        public string Namespace { get; set; }

        public string PipelineDefinitionId { get; set; }

        public string HelmReleaseName { get; set; }
    }
}
