/*----------------------------------------------------------------
* 项目名称 ：Extensions.ServiceConfigures
* 项目描述 ：IdentityServer4扩展方法
* 类 名 称 ：IdentityService4
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Extensions.ServiceConfigures
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/1/29 14:16:37
* 更新时间 ：2022/1/29 14:16:37
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Extensions.ServiceConfigures.Authentication.IdentityServer4;
using IdentityServer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.ServiceConfigures
{
    public static class IdentitySetUp
    {

        public static void AddAuthentication_Ids4Setup(this IServiceCollection services)
        {
            services.AddIdentityServer()
               .AddDeveloperSigningCredential()
               .AddInMemoryIdentityResources(IdentityserverConfig.GetIdentityResourceResources())
               .AddInMemoryApiResources(IdentityserverConfig.GetApiResources())
               .AddInMemoryClients(IdentityserverConfig.GetClients())
               .AddResourceOwnerValidator<ResourceOwnerPasswordValidator>()
               .AddProfileService<ProfileService>()
               .AddInMemoryApiScopes(IdentityserverConfig.ApiScopes);
        }
    }
}
