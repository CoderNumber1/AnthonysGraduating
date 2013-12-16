using AnthonysGraduating.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AnthonysGraduating
{
    public class MvcApplication : System.Web.HttpApplication
    {
        async Task<bool> AddRoleAndUser()
        {
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            RoleManager<IdentityRole> IdentityManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

            if (!await IdentityManager.RoleExistsAsync("Admin"))
            {
                var adminRole = new IdentityRole("Admin");
                IdentityResult adminCreateResult = await IdentityManager.CreateAsync(adminRole);
            }

            var adminUser = new ApplicationUser() { UserName = "Anthony" };
            var adminUserCreateResult = await userManager.CreateAsync(adminUser, "GradPower135");


            var adminUserAddToRoleResult = await userManager.AddToRoleAsync(adminUser.Id, "Admin");

            return true;
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AddRoleAndUser();
        }
    }
}
