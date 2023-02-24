using k8s;
using k8s.KubeConfigModels;

namespace Vindik8s
{
    public class KNamespace
    {
        string _name;


        public KNamespace(string name)
        {
            _name = name;
        }

        public string Thingy1()
        {
            var thingy = new Kubernetes();

        }



    }
}