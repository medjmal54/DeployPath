namespace DeployPathBlazor.Models
{
    public class WorkflowStep
    {
        public WorkflowStep(string name, string icon)
        {
            Name = name;
            Icon = icon;
        }

        public string Name { get; set; }
        public string Icon { get; set; }
        public bool IsActive { get; set; }
    }
}
