namespace TicketSystem.MVC.Models.AppConfigration
{
    public class DataConfigration
    {
        public const string KeySection = "Data";
        public int Age { get; set; }
        public string Name { get; set; } = string.Empty;
        public string[] Lang { get; set; } = [];
    }
}
