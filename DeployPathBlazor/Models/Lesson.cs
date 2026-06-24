namespace DeployPathBlazor.Models
{
    public class Lesson
    {
        public string Id { get; set; } = "";
        public string Title { get; set; } = "";
        public string Goal { get; set; } = "";
        public string Prerequisites { get; set; } = "";
        public string WhyMatters { get; set; } = "";
        public string Guide { get; set; } = "";
        public string Summary { get; set; } = "";

        public List<CommandInfo> Commands { get; set; } = [];
        public List<ErrorInfo> Errors { get; set; } = [];
    }
}
