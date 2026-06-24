namespace DeployPathBlazor.Models
{
    public class K8sPod
    {
        public K8sPod(string name, string shortName, bool isSpinningUp)
        {
            Name = name;
            ShortName = shortName;
            IsSpinningUp = isSpinningUp;
        }

        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool IsSpinningUp { get; set; }
    }
}
