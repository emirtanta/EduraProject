using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.IdentityCore
{
    public class ApplicationIdentityDbContext:IdentityDbContext<ApplicationUser>
    {

        //cmd ekranına dotnet ef migrations add InitialIdentityDb -c ApplicationIdentityDbContex şeklinde yaz ve veritabanını yükle
        //ardından dotnet ef database update -c ApplicationIdentityDbContext migrations'u aktif et
        public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options):base(options)
        {

        }
    }
}
