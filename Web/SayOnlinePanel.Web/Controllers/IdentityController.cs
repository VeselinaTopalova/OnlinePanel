using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SayOnlinePanel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayOnlinePanel.Web.Controllers
{
    public class IdentityController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;

        public IdentityController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Create()
        {
            var poweruser = new ApplicationUser
            {
                UserName = "admin@email.com",
                Email = "admin@email.com",
                EmailConfirmed = false,
            };
            string adminPassword = "p@$$w0rd";

            var result = await this.userManager.CreateAsync(poweruser, adminPassword);
            return this.Json(result);
        }

        public async Task<IActionResult> AddUserToAdmin()
        {
            if (!await this.roleManager.RoleExistsAsync("Admin"))
            {
                await this.roleManager.CreateAsync(new ApplicationRole
                {
                    Name = "Admin",
                });
            }
            var userA = await this.userManager.FindByEmailAsync("admin@email.com");
            var result = await this.userManager.AddToRoleAsync(userA, "Admin");
            return this.Json(result);
        }
    }
}
