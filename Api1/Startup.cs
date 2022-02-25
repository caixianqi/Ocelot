
using Api1Server;
using Extensions.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Api1
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
            services.AddAuthentication("Bearer")
              .AddIdentityServerAuthentication(options =>
              {
                  options.Authority = "http://localhost:5002";
                  options.RequireHttpsMetadata = false;

                  options.ApiName = "Api1";
              });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime applicationLifetime)
        {
            app.UseRequestCulture();
            app.Use(next =>
            {
                return
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //app.ServiceRegister(applicationLifetime, Configuration);
        }

        public delegate Task OcelotRequestDelegate(DownstreamContext downstreamContext);

        OcelotRequestDelegate ocelotRequest = (context) => {
            return Task.CompletedTask;

        };

        Func<OcelotRequestDelegate, OcelotRequestDelegate> Celo  ;

        

        public  OcelotRequestDelegate getdads(OcelotRequestDelegate ocelotRequest)
        {
            return ocelotRequest;
        }

        Celo=getdads
    }
}
