using IdentityModel.OidcClient;
using k8s;
using System.Security.Cryptography;

namespace Vindik8s
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            // Instantiates an object that will give us all namespaces
            var kubeCluster = new KubernetesClusterOverview();

            // Testing a print job on ListAllNamespaces
            //var result1 = (await kubeCluster.ListAllNamespaces())["nf-c17-uks-aks-k8s"];
            //var result = string.Join(",", result1);
            //Console.WriteLine(result);

            // Select one Namespace, give results


            //var namespacesPRList = await kubeCluster.ListNamespaces("nf-pr-uks-aks-k8s");
            //var namespacesPRString = string.Join(",", namespacesPRList);
            //var currentNamespaces = string.Join(",", (await kubeCluster.ListNamespaces()));

            //Console.WriteLine($" c17 - {string.Join(",", (await kubeCluster.ListNamespaces()))}");

            //Console.WriteLine($" pr - {namespacesPRString}");

            var podQuery = new KubernetesPod("nf-c17-uks-aks-k8s", "corporate");

            var podsInC17 = podQuery.GetPods();

            Console.WriteLine(string.Join(",", podsInC17));

        }
    }
}