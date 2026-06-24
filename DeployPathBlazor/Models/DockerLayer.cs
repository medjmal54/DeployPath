namespace DeployPathBlazor.Models
{
    public class DockerLayer
    {
        public DockerLayer(string instruction, string size)
        {
            Instruction = instruction;
            Size = size;
        }

        public string Instruction { get; set; }
        public string Size { get; set; }
        public string StateClass { get; set; } = "";
    }
}
