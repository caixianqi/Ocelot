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
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Repository.Base;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
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
            services.AddSingleton(new IdentityserverConfig(Configuration));
            services.AddAuthentication_Ids4Setup();
            services.AddSingleton(new Appsettings(Configuration));
            services.AddDbContext<EntityFrameWorkIdentityDbcontext>(options => options.UseSqlServer(Configuration.GetConnectionString("Sqlserver")));
            services.AddScoped<DbContext, EntityFrameWorkIdentityDbcontext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime applicationLifetime, IOptions<IndentityServerClient> options)
        {
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
        }

        public void ConfigureContainer(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule<AutofacSetup>();
        }
    }
}
