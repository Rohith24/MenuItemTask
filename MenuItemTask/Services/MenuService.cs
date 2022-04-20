using MenuItemTask.ViewModels;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MenuItemTask.Services
{
    public class MenuService : IMenuService
    {
        private AppDbContext _appDbContext;
        public MenuService(AppDbContext context)
        {
            _appDbContext = context;
        }

        private List<MenuItem> GetSubMenuItems(int id)
        {
            var menuItems = _appDbContext.Menus.Where(m => m.SubMenuId == id).ToList();
            if (!menuItems.Any()) return null;
            var menu = new List<MenuItem>();
            foreach (var menuItem in menuItems)
            {
                menu.Add(new MenuItem
                {
                    HelpText = menuItem.HelpText,
                    Id = menuItem.Id,
                    Title = menuItem.Text,
                    URL = menuItem.URL,
                    SubMenuItems = GetSubMenuItems(menuItem.Id)
                });
            }
            return menu;
        }

        public List<MenuItem> GetMenuItems()
        {
            return GetSubMenuItems(0);
        }
    }
}
