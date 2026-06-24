namespace DeployPathBlazor.Models
{
    public class ConsoleLine
    {
        public ConsoleLine(string text, string cssClass)
        {
            Text = text;
            CssClass = cssClass;
        }

        public string Text { get; set; }
        public string CssClass { get; set; }
    }
}
