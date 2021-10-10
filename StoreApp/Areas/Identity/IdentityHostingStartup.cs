using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StoreApp.Areas.Identity.Data;
using StoreApp.Data;

[assembly: HostingStartup(typeof(StoreApp.Areas.Identity.IdentityHostingStartup))]
namespace StoreApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<StoreAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("StoreAppContextConnection")));

                services.AddDefaultIdentity<StoreAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<StoreAppContext>();
            });
        }
    }
}