using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.IdentityCore
{
    public static class SeedIdentity
    {
        public static async Task CreateIdentityUsers(IServiceProvider serviceProvider,IConfiguration configuration)
        {
            //kullanıcı giriş-çıkış-kayıt işlemleri için tanımlandı
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            //rol işlemleri için tanımlandı
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //appsettings.json kısmındaki Data bölümündeki dataların alımı
            var userName = configuration["Data:AdminUser:username"];
            var email = configuration["Data:AdminUser:email"];
            var password = configuration["Data:AdminUser:password"];
            var role = configuration["Data:AdminUser:role"];

            if (await userManager.FindByNameAsync(userName)==null)
            {
                if (await roleManager.FindByNameAsync(role)==null)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }

                ApplicationUser user = new ApplicationUser()
                {
                    UserName=userName,
                    Email=email,
                    Name="Sadık",
                    Surname="Turan"
                };

                IdentityResult result = await userManager.CreateAsync(user, password);

                //kullanıcı varsa
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }
    }
}
