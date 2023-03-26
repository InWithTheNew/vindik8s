namespace Vindik8s.Web.Models
{
    public class Namespace
    {
        public Namespace()
        {
            Microservices = new List<Microservice>();
        }

        public Namespace(string name)
            : this()
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string Name { get; set; }

        public List<Microservice> Microservices { get; set; }
    }
}
