using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exellent_Taste.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Exellent_Taste.BUS.Interface;
using Exellent_Taste.BUS.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using Rotativa.AspNetCore;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Exellent_Taste.WEB
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


            services.AddControllersWithViews();
            //database context 
            services.AddDbContext<ExellentDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));
            services.AddScoped<IGebruikersService, GebruikersService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IReseveringenService, ReseveringenService>();
            services.AddScoped<IMenukaartService, MenukaartService>();
            services.AddScoped<IMenuSoortService, MenuSoortService>();
            services.AddScoped<IBlackListService, BlackListService>();
            services.AddScoped<IBestellingenService, BestellingenService>();
            services.AddScoped<IBestellings_LijstService, Bestellings_LijstService>();

            //httpcontext services
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //session serivce
            services.AddSession();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseCookiePolicy();
            app.UseStaticFiles();
            app.UseSession();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            RotativaConfiguration.Setup(env, "..\\Rotativa\\");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Index}/{id?}");
            });
        }
    }
}
