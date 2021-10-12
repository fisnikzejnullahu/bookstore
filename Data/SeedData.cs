using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Data
{
    public class SeedData
    {
        public static void SeedAdmin(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRole(roleManager);
            SeedUser(userManager);
        }

        private static void SeedRole(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Administrator";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }

        private static void SeedUser(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("admin@bookstore.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "admin@bookstore.com";
                user.Email = "admin@bookstore.com";

                IdentityResult result = userManager.CreateAsync(user, "Admin123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
        }
    }
}
