using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k8s;
using k8s.KubeConfigModels;

namespace vindik8s
{
    public class KubernetesPod
    {
        List<string> podList;

        public KubernetesPod(string clusterName, string kNamespace)
        {
            string _clusterName = clusterName;
            string _kNamespace = kNamespace;

            var config = KubernetesClientConfiguration.BuildConfigFromConfigFile(currentContext: clusterName);
            var client = new Kubernetes(config);

            var podList = client.CoreV1.ListNamespacedPod(kNamespace).Items.Select(x => x.Metadata.Name).ToList();
        }

        public List<string> GetPods()
        {
            return podList; 
        }
    }
}
