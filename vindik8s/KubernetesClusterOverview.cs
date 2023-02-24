using k8s;
using k8s.KubeConfigModels;
using System.Security.Cryptography.X509Certificates;

namespace Vindik8s
{
    public class KubernetesClusterOverview
    {
        List<string> _namespaces = new List<string>();

        List<string> _contexts;

        public KubernetesClusterOverview()
        {
            //Load kubeConfig & get all clusters

            _contexts = KubernetesClientConfiguration.LoadKubeConfig().Contexts.Select(x => x.Name).ToList();

            //Foreach context in contexts, log in? Get Namespaces? Make custom class for these things
        }

        public async Task<Dictionary<string, List<string>>> ListAllNamespaces()
        {
            var contextsAndNamespaces = new Dictionary<string, List<string>>();

            foreach (var context in _contexts)
            {
                var config = KubernetesClientConfiguration.BuildConfigFromConfigFile(currentContext: context);
                var client = new Kubernetes(config);

                var clusterNamespaces = new k8s.Models.V1NamespaceList();

                try
                {
                    clusterNamespaces = await client.CoreV1.ListNamespaceAsync();
                }
                catch (Exception ex)
                {
                    //Console.Write($"Error: {context} \n {ex}");
                    continue;
                }

                var namespaces = clusterNamespaces.Items.Select(x => x.Metadata.Name).ToList();

                contextsAndNamespaces.Add(context, namespaces);
            }

            return contextsAndNamespaces;

        }

        public async Task<List<string>> ListNamespaces(string context = null)
        {
            var namespaces = new List<string>();

            var config = KubernetesClientConfiguration.BuildConfigFromConfigFile();

            if (context != null)
            {

                config = KubernetesClientConfiguration.BuildConfigFromConfigFile(currentContext: context);
            }

            var client = new Kubernetes(config);

            var clusterNamespaces = new k8s.Models.V1NamespaceList();

            clusterNamespaces = await client.CoreV1.ListNamespaceAsync();

            namespaces = clusterNamespaces.Items.Select(x => x.Metadata.Name).ToList();

            return namespaces;

        }

        public async Task<Dictionary<string, string, Boolean>> CheckServices()
        {

        }
    }
}
