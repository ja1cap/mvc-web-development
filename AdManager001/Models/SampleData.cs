using System;
using System.Linq;
using System.Threading.Tasks;
using AdManager001.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AdManager001.Models
{
    public class SampleData
    {
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                string[] roles = new string[] { "ADMIN", "PUBLISHER", "ADVERTISER" };

                var roleStore = new RoleStore<IdentityRole>(context);
                foreach (string role in roles)
                {
                    if (!context.Roles.Any(r => r.Name == role))
                    {
                        await roleStore.CreateAsync(new IdentityRole { Name = role, NormalizedName = role });
                    }
                }


                var user = new ApplicationUser
                {
                    //FirstName = "XXXX",
                    //LastName = "XXXX",
                    Email = "admin@weasty.com",
                    NormalizedEmail = "ADMIN@WEASTY.COM",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN@WEASTY.COM",
                    PhoneNumber = "+375296150391",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };

                if (!context.Users.Any(u => u.UserName == user.UserName))
                {
                    var password = new PasswordHasher<ApplicationUser>();
                    var hashed = password.HashPassword(user, "Pas$w0rd");
                    user.PasswordHash = hashed;

                    var userStore = new UserStore<ApplicationUser>(context);
                    await userStore.CreateAsync(user);
                    foreach (string role in roles)
                    {
                        await userStore.AddToRoleAsync(user, role);
                    }
                }

                await context.SaveChangesAsync();
            }
        }
    }
}
