namespace DeployPathBlazor.Models
{
    public class Category
    {
        public string Id { get; set; } = "";
        public string Title { get; set; } = "";
        public string Subtitle { get; set; } = "";
        public string Description { get; set; } = "";
        public string Badge { get; set; } = "";

        public List<Module> Modules { get; set; } = [];
    }
}
