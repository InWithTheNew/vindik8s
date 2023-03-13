using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k8s;
using k8s.KubeConfigModels;

namespace Vindik8s.ClassLibrary
{
    public class KubernetesNamespace
    {
        string _clusterName;
        List<string> _namespaces;

        public KubernetesNamespace(string clusterName)
        {
            _clusterName = clusterName;
            _namespaces = new List<string>();
        }

        public async Task<List<string>> GetNamespaces()
        {
            var namespaces = new List<string>();
            var config = KubernetesClientConfiguration.BuildConfigFromConfigFile();

            if (_clusterName != null)
            {
                config = KubernetesClientConfiguration.BuildConfigFromConfigFile(currentContext: _clusterName);
            }

            var client = new Kubernetes(config);

            var clusterNamespaces = new k8s.Models.V1NamespaceList();

            clusterNamespaces = await client.CoreV1.ListNamespaceAsync();

            return clusterNamespaces.Items.Select(x => x.Metadata.Name).ToList();

        }
    }
}