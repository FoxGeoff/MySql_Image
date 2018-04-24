using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MySql_Image.Data;
using MySql_Image.Data.Entities;
using MySql_Image.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace MySql_Image
{
    public class Startup
    {
        private readonly IConfiguration _config;
        private readonly IHostingEnvironment _env;
        private readonly string _dbconnect = null;

        public Startup(IConfiguration config, IHostingEnvironment env)
        {
            _config = config;
            _env = env;
            _dbconnect = _config["dbconnect3"];
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            if (_env.IsDevelopment())
            {
                /* Alternative: for connection string from config.json (not a sercure configuraion)
                services.AddDbContext<ProductImageDbContext>(options =>
                options.UseMySql(_config.GetConnectionString("dbconnect"))); */

                services.AddDbContext<ProductImageDbContext>(options =>
                options.UseMySql(_dbconnect));
            }

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ProductImageDbContext>()
                .AddDefaultTokenProviders();

            services.AddAuthorization(config => {
                config.AddPolicy("CanadiansOnly", policy => policy.RequireClaim(ClaimTypes.Country, "Canada"));
                config.AddPolicy("CanadianOrAdmin", policy => policy.AddRequirements(new CanadianRequirement()));
            });

            services.AddTransient<ProductImageSeeder>();

            services.AddMvc()
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AuthorizeFolder("/Account/Manage");
                    options.Conventions.AuthorizePage("/Account/Logout");
                });

            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Audio Impact API",
                    Description = "An example ASP.NET Core Web API",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Geoff Fox",
                        Email = "DevTestOnly@outlook.com",
                        Url = "https://fox-Graphics.com"
                    },
                    License = new License
                    {
                        Name = "Use under LICX",
                        Url = "https://example.com/license"
                    }
                });
            });

            //Support for development real email service
            services.AddTransient<IMailService, RealMailService>();
            /* Alternative: for a null email service 
            services.AddTransient<IMailService, NullMailService>(); */

            //TODO: Register no-op EmailSender used by account confirmation and password reset during development
            // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=532713
            //==> services.AddSingleton<IEmailSender, EmailSender>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            if (_env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            /* http://localhost:50254/swagger/ */
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                //c.RoutePrefix = string.Empty;
            });

            app.UseAuthentication();

            /* We may have to calling it sync because async Configure() method was reported to have issues */
            SampleData.InitializeData(app.ApplicationServices, loggerFactory).Wait();

            /* await SampleData.InitializeData(app.ApplicationServices, loggerFactory); */

            app.UseMvc(route =>
            {
                route.MapRoute("Default",
                "{controller}/{action}/{id?}",
                new { controller = "App", Action = "Index" });
            });

            //TODO: remove
            ////if (_env.IsDevelopment())
            ////{
            ////    using (var scope = app.ApplicationServices.CreateScope())
            ////    {
            ////        if (context.Database != null)
            ////        {
            ////            var seeder = scope.ServiceProvider.GetRequiredService<ProductImageSeeder>();
            ////            seeder.Seed();
            ////        }
            ////    }
            ////}
        }
    }
}
