namespace DeployPathBlazor.Models
{
    public class GitFile
    {
        public GitFile(string name, string status)
        {
            Name = name;
            Status = status;
        }

        public string? Name { get; set; }
        public string? Status { get; set; }
    }
}
