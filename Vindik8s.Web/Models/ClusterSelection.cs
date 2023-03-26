namespace Vindik8s.Web.Models
{
    public class ClusterSelection
    {
        public ClusterSelection(
            string selectedClusterName,
            IReadOnlyCollection<Cluster> clusters)
        {
            SelectedClusterName = selectedClusterName;
            AllClusters = clusters ?? throw new ArgumentNullException(nameof(clusters));
        }

        public string SelectedClusterName { private get; set; }

        public IReadOnlyCollection<Cluster> AllClusters { get; set; }

        public Cluster SelectedCluster => AllClusters.SingleOrDefault(s => s.Name == SelectedClusterName);
    }
}
