namespace SayOnlinePanel.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using SayOnlinePanel.Data.Models;

    public class SeedUserAndAddAdminRole : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var poweruser = new ApplicationUser
            {
                UserName = "admin@email.com",
                Email = "admin@email.com",
                EmailConfirmed = false,
            };
            string adminPassword = "p@$$w0rd";

            await userManager.CreateAsync(poweruser, adminPassword);
            await dbContext.Users.AddAsync(poweruser);

            var userA = await userManager.FindByEmailAsync("admin@email.com");
            await userManager.AddToRoleAsync(userA, "Administrator");
        }
    }
}
