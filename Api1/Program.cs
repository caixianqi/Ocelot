using Api1Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api1
{
    public class Program
    {
        public  void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
             Func<OcelotRequestDelegate, OcelotRequestDelegate> Celo= getdads;
            Celo(ocelotRequest);
        }

        public delegate Task OcelotRequestDelegate(DownstreamContext downstreamContext);

        OcelotRequestDelegate ocelotRequest = (context) => {
            return Task.CompletedTask;

        };

        Func<OcelotRequestDelegate, OcelotRequestDelegate> Celo;



        public OcelotRequestDelegate getdads(OcelotRequestDelegate ocelotRequest)
        {
            return ocelotRequest;
        }

        

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
