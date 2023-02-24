using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k8s;
using k8s.KubeConfigModels;

namespace Vindik8s
{
    public class KubernetesNamespace
    {
        string _name;

        public KubernetesNamespace(string name)
        {
            _name = name;
        }

        public string Thingy1()
        {
            var thingy = new Kubernetes();

        }



    }
}