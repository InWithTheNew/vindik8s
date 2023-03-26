using Vindik8s.ClassLibrary.Models;

namespace Vindik8s.Web.Models
{
    public class Microservice : NoviaMicroservice
    {
        public Microservice(string name, string pipelineDefinitionId, string helmReleaseName)
            : base(name, pipelineDefinitionId, helmReleaseName)
        {
        }
    }
}
