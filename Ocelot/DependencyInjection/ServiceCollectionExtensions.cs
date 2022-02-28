/*----------------------------------------------------------------
* 项目名称 ：Ocelot.DependencyInjection
* 项目描述 ：
* 类 名 称 ：ServiceCollectionExtensions
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.DependencyInjection
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/2/28 17:10:45
* 更新时间 ：2022/2/28 17:10:45
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddOcelot(this IServiceCollection services, IConfiguration configuration)
        {
             new OcelotBuilder(services, configuration);
        }
    }
}
