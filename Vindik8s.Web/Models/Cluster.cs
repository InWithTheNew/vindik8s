namespace Vindik8s.Web.Models
{
    public class Cluster
    {
        public Cluster()
        {
            Namespaces = new List<Namespace>();
        }

        public Cluster(string name)
            : this()
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string Name { get; set; }

        public List<Namespace> Namespaces { get; set; }
    }
}
