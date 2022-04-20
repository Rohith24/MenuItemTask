using System.Collections.Generic;

namespace MenuItemTask.ViewModels
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string HelpText { get;set; }
        public string URL { get; set; }

        public List<MenuItem> SubMenuItems { get; set; }
    }
}
