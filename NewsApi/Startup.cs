using Hangfire;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using CoreApp;
using IndexOfPositiveAdd;
using Lemmatization;
using MediatR;
using Model1;
using MyMediatr.Commands.CommentsCommand;
using MyMediatr.Commands.NewsCommand;
using MyMediatr.Handlers.CommentsHandler;
using MyMediatr.Handlers.NewsHandlers;
using MyMediatr.Queries.CommentsQueries;
using MyMediatr.Queries.NewsQueries;
using Services;
using Swashbuckle.AspNetCore.Swagger;
using ParsingNews;

namespace Mediatr
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
            services.AddCors();



            services.AddMediatR(typeof(Startup));
            services.AddDbContext<DbContent>(option => option.UseSqlServer(_conf.GetConnectionString("DefaultConnection")));
           
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<DbContent>().AddDefaultTokenProviders();
            services.AddHangfire(Configuration => Configuration.UseSqlServerStorage(_conf.GetConnectionString("DefaultConnection")));
           services.AddTransient<IHangfireNews, HangfireNews>();
            
            services.AddTransient<IRaitOfPositiv, Positiv>();
            services.AddTransient<ILemmatization, LemmatizationImpl>();
            services.AddTransient<IAfinn165, Afinn165>();
            services.AddTransient<IParsUrlForRss, ParsUrlForRss>();
            services.AddTransient<IAddNews, AddNews>();
            services.AddTransient< IRequestHandler<GetAllNewsQuery, DbSet<News>>, GetAllNewsHandler > ();
            services.AddTransient< IRequestHandler<GetNewsQuery, News>, GetNewsHandler > ();
            services.AddTransient< IRequestHandler<CreateNewsCommand, Guid >, CreateNewsHandler > ();
            services.AddTransient< IRequestHandler<RemoveNewsCommand, string>, RemoveNewsHandler > ();
            services.AddTransient< IRequestHandler<CreateCommentCommand, Guid>, CreateCommentHandler> ();
            services.AddTransient< IRequestHandler<RemoveCommentsCommand, string>, DeleteCommentHandler > ();
            services.AddTransient<IRequestHandler<GetCommentsQuery, DbSet<Comments>>, GetallCommentsHandler>();
            services.AddTransient< IRequestHandler<GetCommentQuery, Comments>, GetCommentHandler > ();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info{ Title = "NewsApi", Version = "v1" });
            });

           

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
                            IssuerSigningKey =
                                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:JwtKey"])),
                            ClockSkew = TimeSpan.FromMinutes(5) // remove delay of token when expire
                        };
                    });

                services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IHangfireNews hangfireNews,IRaitOfPositiv rait)
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
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "NewsAPI V1");
                
            });

            app.UseHangfireServer();
            app.UseHangfireDashboard();
           RecurringJob.AddOrUpdate( () => hangfireNews.TaskNewsAddStart(), Cron.Minutely);
            // RecurringJob.AddOrUpdate(() => rait.PositiveAdd(), Cron.Minutely);

            app.UseCors(builder => builder.AllowAnyOrigin());

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
