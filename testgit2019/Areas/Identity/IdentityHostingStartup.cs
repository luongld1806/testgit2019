using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using testgit2019.Areas.Identity.Data;
using testgit2019.Data;

[assembly: HostingStartup(typeof(testgit2019.Areas.Identity.IdentityHostingStartup))]
namespace testgit2019.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<testgit2019Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("testgit2019ContextConnection")));

                services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<testgit2019Context>();
            });
        }
    }
}