namespace DeployPathBlazor.Models
{
    public class GitCommit
    {
        public GitCommit(string? hash, string? message)
        {
            Hash = hash;
            Message = message;
        }

        public string? Hash { get; set; }
        public string? Message { get; set; }
    }
}
