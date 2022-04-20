using MenuItemTask.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace MenuItemTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuItemController : ControllerBase
    {

        private readonly ILogger<MenuItemController> _logger;

        public IMenuService _menuService;


        public MenuItemController(ILogger<MenuItemController> logger, IMenuService menuService)
        {
            _logger = logger;
            _menuService = menuService;
        }

        [HttpGet("get-menu")]

        public IActionResult GetMenuItems()
        {
            try
            {
                return Ok(_menuService.GetMenuItems());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unable to get menu items");
                return BadRequest(ex);
            }
        }
    }
}
