namespace DeployPathBlazor.Models
{
    public class TroubleshootArticleInfo
    {
        public string Slug { get; set; } = "";
        public string Title { get; set; } = "";
        public string Category { get; set; } = "";
        public string Description { get; set; } = "";
        public string Guide { get; set; } = "";
        public string Solution { get; set; } = "";
        public string? Command { get; set; }
        public string Severity { get; set; } = "Medium";
        public string[] Tags { get; set; } = Array.Empty<string>();
    }
}
