using Autofac;
using Autofac.Extensions.DependencyInjection;
using Domain.Models;
using Extensions.Middlewares;
using Extensions.ServiceConfigures;
using Extensions.ServiceConfigures.AppSettings;
using Extensions.ServiceConfigures.AppSettings.Model;
using Extensions.ServiceConfigures.Authentication.IdentityServer4;
using Extensions.ServiceConfigures.AutofacConfig;
using IdentityDbContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Polly;
using Repository.Base;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace IdentityServer
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
            services.AddControllers();
            services.AddOcelot((new ConfigurationBuilder().AddJsonFile("ocelot.json", true, true).Build())).AddPolly();
            services.AddSingleton(new IdentityserverConfig(Configuration));
            services.AddAuthentication_Ids4Setup();
            services.AddSingleton(new Appsettings(Configuration));
            services.AddDbContext<EntityFrameWorkIdentityDbcontext>(options => options.UseMySQL(Configuration.GetConnectionString("Mysql")));
            services.AddScoped<DbContext, EntityFrameWorkIdentityDbcontext>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime applicationLifetime, EntityFrameWorkIdentityDbcontext dbcontext)
        {
            app.Use(async (context, next) =>
            {
                var cultureQuery = context.Request.Query["culture"];
                if (!string.IsNullOrWhiteSpace(cultureQuery))
                {
                    var culture = new CultureInfo(cultureQuery);

                    CultureInfo.CurrentCulture = culture;
                    CultureInfo.CurrentUICulture = culture;
                }
                await next.Invoke();
                // Call the next delegate/middleware in the pipeline
                
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(
                    $"Hello {CultureInfo.CurrentCulture.DisplayName}");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseIdentityServer();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.ServiceRegister(applicationLifetime, Configuration);
            app.UseOcelot();
        }

        public void ConfigureContainer(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule<AutofacSetup>();
        }
    }
}
