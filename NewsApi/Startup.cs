using System;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Text;
using Core;
using Core.Models;
using Core.Repo;

using Hangfire;
using HappyNews.Entities;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NewsApi.MediatR;
using NewsApi.MediatR.Repositories;

namespace NewsApi
{
    public class Startup
    {
        private readonly IConfigurationRoot _conf;

      
    

       public Startup(IHostingEnvironment host, IConfiguration configuration)
       {
           _conf = new ConfigurationBuilder().SetBasePath(host.ContentRootPath).AddJsonFile("DbConnection.json").Build();
           Configuration = configuration;
            }

     
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DbContent>(option => option.UseSqlServer(_conf.GetConnectionString("DefaultConnection")));
            services.AddTransient<IGenericRepository<News>, NewsRepo>();
            services.AddTransient<IGenericRepository<Comments>, CommentsRepo>();
            services.AddMediatR(typeof(Startup));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DbContent>().AddDefaultTokenProviders();
            services.AddHangfire(Configuration => Configuration.UseSqlServerStorage(_conf.GetConnectionString("DefaultConnection")));
            
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear(); // => remove default claims
            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

                })
                .AddJwtBearer(cfg =>
                {
                    cfg.RequireHttpsMetadata = false;
                    cfg.SaveToken = true;
                    cfg.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = Configuration["JWT:JwtIssuer"],
                        ValidAudience = Configuration["JWT:JwtIssuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:JwtKey"])),
                        ClockSkew = TimeSpan.FromMinutes(5)// remove delay of token when expire
                    };
                });
            services.AddScoped<IGenericApiRepository<News>, NewsRepository>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
         
            app.UseHangfireServer();
            app.UseHangfireDashboard();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
