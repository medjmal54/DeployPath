namespace DeployPathBlazor.Models
{
    public class DockerfileLine
    {
        public DockerfileLine(string text, string highlightClass)
        {
            Text = text;
            HighlightClass = highlightClass;
        }

        public string Text { get; set; }
        public string HighlightClass { get; set; }
    }
}
