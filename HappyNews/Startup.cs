using Core;
using Core.Models;
using Core.Repo;
using HappyNews.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.UoW;

namespace HappyNews
{
    public class Startup
    {
        
        private readonly IConfigurationRoot _conf;
       
        public Startup(IHostingEnvironment host)
        {
            _conf =new ConfigurationBuilder().SetBasePath(host.ContentRootPath).AddJsonFile("DbConnection.json").Build();
        }
    
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DbContent>(option=>option.UseSqlServer(_conf.GetConnectionString("DefaultConnection")));

            //services.AddDbContext<ApplicationContext>(option => option.UseSqlServer(_conf.GetConnectionString("DefaultConnection")));

          
            services.AddTransient<IGenericRepository<News>,NewsRepo>();
            services.AddTransient<IGenericRepository<Comments>,CommentsRepo>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<DbContent>();

            services.AddMvc();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var scope = app.ApplicationServices.CreateScope()){
               var content = scope.ServiceProvider.GetRequiredService<DbContent>();
               
           }

            
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
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
