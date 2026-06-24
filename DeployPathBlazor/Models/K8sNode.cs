using static DeployPathBlazor.Components.K8sPlayground;

namespace DeployPathBlazor.Models
{
    public class K8sNode
    {
        public K8sNode(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<K8sPod> Pods { get; set; } = new();
    }
}
