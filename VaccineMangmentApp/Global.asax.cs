using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using VaccineMangmentApp.Database;

namespace VaccineMangmentApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            using (var ctx = new VaccineMasterEntities1())
            {
                if (!ctx.UserMasters.Any(x => x.EmailID == "admin@admin.com"))
                {
                    ctx.UserMasters.Add(new UserMaster
                    {
                        Address = "Default",
                        Age = 23,
                        City = "Default",
                        DOB = DateTime.Now,
                        EmailID = "admin@admin.com",
                        FirstName = "Admin",
                        IsAdmin = true,
                        LastName = "Admin",
                        MobileNo = "8888888888",
                        Password = "Admin@22",
                        UserID = 0,
                    });
                    ctx.SaveChanges();
                }
            }
        }
    }
}