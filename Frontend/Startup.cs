using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Frontend.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
namespace Frontend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<UserService>();
            services.AddSingleton<HistoryService>();
            services.AddSingleton<ToolService>();
            services.AddSingleton<RoomService>();
            services.AddControllersWithViews();

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;

            })
            .AddCookie(opts =>
            {
                opts.LoginPath = "/StartPage";
                opts.AccessDeniedPath = "/MainPage";
            });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=StartPage}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "main",
                    pattern: "{controller=MainPage}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "booking",
                    pattern: "{controller=Booking}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "homeadmin",
                    pattern: "{controller=HomeAdmin}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "history",
                    pattern: "{controller=Booking}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "selectPage",
                    pattern: "{controller=SelectPage}/{action=Index}/{id?}");

            });
        }
    }
}
