using MenuItemTask.Models;
using MenuItemTask.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BooksManagement.DataAcess
{
    public class AppDbInitialer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Menus.Any())
                {
                    context.Menus.AddRange(new MenuItem()
                    {
                        Text = "Page1",
                        URL = "~/Page1.Aspx",
                        HelpText = "Page 1",
                        SubMenuId = 0,
                    },
                    new MenuItem()
                    {
                        Text = "Page2",
                        URL = "~/Page2.Aspx",
                        HelpText = "Page 2",
                        SubMenuId = 0,
                    },
                    new MenuItem()
                    {
                        Text = "Page3",
                        URL = "~/Page3.Aspx",
                        HelpText = "Page 3",
                        SubMenuId = 0,
                    }
                    , new MenuItem()
                    {
                        Text = "Sub Page 1-1",
                        URL = "~/Sub1/Page1.Aspx",
                        HelpText = "Sub Page 1-1",
                        SubMenuId = 1,
                    }, new MenuItem()
                    {
                        Text = "Sub Page 1-2",
                        URL = "~/Sub1/Page2.Aspx",
                        HelpText = "Sub Page 1-2",
                        SubMenuId = 1,
                    }, new MenuItem()
                    {
                        Text = "Sub Page 1-3",
                        URL = "~/Sub1/Page3.Aspx",
                        HelpText = "Sub Page 1-3",
                        SubMenuId = 1,
                    }, new MenuItem()
                    {
                        Text = "Sub Page 2-1",
                        URL = "~/Sub2/Page1.Aspx",
                        HelpText = "Sub Page 1-2",
                        SubMenuId = 2,
                    },
                    new MenuItem()
                    {
                        Text = "Sub Page 2-2",
                        URL = "~/Sub2/Page2.Aspx",
                        HelpText = "Sub Page 2-2",
                        SubMenuId = 2,
                    }, new MenuItem()
                    {
                        Text = "Sub Page 2-1-1",
                        URL = "~/Sub2/Sub1/Page1.Aspx",
                        HelpText = "Sub Page 2-1-1",
                        SubMenuId = 7,
                    }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
