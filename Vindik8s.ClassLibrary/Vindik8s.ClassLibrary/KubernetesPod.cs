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
        List<string> podList;

        public KubernetesPod(string clusterName, string kubernetesNamespace)
        {
            string _clusterName = clusterName;
            string _kNamespace = kubernetesNamespace;

            var config = KubernetesClientConfiguration.BuildConfigFromConfigFile(currentContext: _clusterName);
            var client = new Kubernetes(config);

            var podList = client.CoreV1.ListNamespacedPod(kubernetesNamespace).Items.Select(x => x.Metadata.Name).ToList();
        }

        public List<string> GetPods()
        {
            return podList; 
        }
    }
}
