using Vindik8s.ClassLibrary.Models;

namespace Vindik8s.Web.Models
{
    public class Namespace
    {
        public Namespace()
        {
            Microservices = new List<(NoviaMicroservice, bool)>();
        }

        public Namespace(string name)
            : this()
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string Name { get; set; }

        public List<(NoviaMicroservice, bool)> Microservices { get; set; }
    }
}
