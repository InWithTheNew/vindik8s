namespace Vindik8s.Web.Models
{
    public class ClusterSelection
    {
        public ClusterSelection(
            string selectedClusterName,
            IReadOnlyCollection<Cluster> clusters)
        {
            SelectedClusterName = selectedClusterName;
            Clusters = clusters ?? throw new ArgumentNullException(nameof(clusters));
        }

        public string SelectedClusterName { private get; set; }

        public IReadOnlyCollection<Cluster> Clusters { get; set; }

        public Cluster SelectedCluster => Clusters.SingleOrDefault(s => s.Name == SelectedClusterName);
    }
}
