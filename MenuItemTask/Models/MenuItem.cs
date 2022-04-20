namespace MenuItemTask.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string HelpText { get; set; }
        public string URL { get; set; }
        public int SubMenuId { get; set; }
    }
}
