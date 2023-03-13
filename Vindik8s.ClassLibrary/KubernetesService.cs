using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vindik8s.ClassLibrary
{
    internal class KubernetesService
    {
        string _clusterName;
        List<string> _namespaces;

        public KubernetesService(string clusterName, string kubernetesNamespace) { 
            _clusterName = clusterName;
            _namespaces = new List<string>();

        }
    }
}
