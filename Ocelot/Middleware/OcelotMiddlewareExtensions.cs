/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Middleware
* 项目描述 ：
* 类 名 称 ：OcelotMiddlewareExtensions
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Middleware
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 16:02:37
* 更新时间 ：2022/2/28 16:02:37
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/



using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using Ocelot.Configuration.File;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ocelot.Middleware
{
    public static class OcelotMiddlewareExtensions
    {
        public static async Task<IApplicationBuilder> UseOcelot(this IApplicationBuilder builder)
        {
            builder.UseOcelot(new OcelotPipelineConfiguration());
            return builder;
        }

        private static async void UseOcelot(this IApplicationBuilder applicationBuilder, OcelotPipelineConfiguration ocelotPipelineConfiguration)
        {
           CreateConfiguration(applicationBuilder);
        }


        private  static async void CreateConfiguration(IApplicationBuilder builder)
        {
            // make configuration from file system?
            // earlier user needed to add ocelot files in startup configuration stuff, asp.net will map it to this
            var fileConfig = builder.ApplicationServices.GetService(typeof(IOptionsMonitor < FileConfiguration >))as IOptionsMonitor<FileConfiguration>;
            Console.WriteLine(fileConfig.CurrentValue);
        }
    }
}
