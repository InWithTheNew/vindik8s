using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k8s;
using k8s.KubeConfigModels;

namespace Vindik8s.ClassLibrary
{
    public class KubernetesPod
    {
        Kubernetes _client;

        public KubernetesPod(string clusterName)
        {
            var config = KubernetesClientConfiguration.BuildConfigFromConfigFile(currentContext: clusterName);
            _client = new Kubernetes(config);
        }

        public async Task <List<string>> GetPods(string kubernetesNamespace)
        {
            var pods = await _client.CoreV1.ListNamespacedPodAsync(kubernetesNamespace);
            return pods.Items.Select(x => x.Metadata.Name).ToList();
        }
    }
}
