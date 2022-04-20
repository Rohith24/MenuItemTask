using MenuItemTask.Models;
using Microsoft.EntityFrameworkCore;

namespace MenuItemTask.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<MenuItem> Menus { get; set; }

    }
}