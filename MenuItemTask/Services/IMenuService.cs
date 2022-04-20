using MenuItemTask.ViewModels;
using System.Collections.Generic;

namespace MenuItemTask.Services
{
    public interface IMenuService
    {
        List<MenuItem> GetMenuItems();
    }
}