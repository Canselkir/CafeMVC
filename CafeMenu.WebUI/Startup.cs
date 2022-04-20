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
using TaskManager.Business.Abstract;
using TaskManager.DataAccess.Abstract;
using TaskManager.DataAccess.Concrete.EFCore;
using TaskManager.Business.Concrete;
using Microsoft.EntityFrameworkCore;

namespace TaskManager.WebUI
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
            services.AddScoped<IProduct, EFCoreProductRepository>();
            services.AddScoped<ICategory, EFCoreCategoryRepository>();
            services.AddScoped<IProperty, EFCorePropertyRepository>();
            services.AddScoped<IUser, EFCoreUserRepository>();
            services.AddScoped<IProductProperty, EFCoreProductPropertyRepository>();

            services.AddScoped<IProductService, ProductServiceManager>();
            services.AddScoped<ICategoryService, CategoryServiceManager>();
            services.AddScoped<IPropertyService, PropertyServiceManager>();
            services.AddScoped<IUserService, UserServiceManager>();

            services.AddDbContext<TaskManagerContext>();

            services.AddControllersWithViews();
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
