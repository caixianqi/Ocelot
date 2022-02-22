/*----------------------------------------------------------------
* 项目名称 ：Extensions.ServiceConfigures.Authentication.IdentityServer4
* 项目描述 ：Identityserver4配置类
* 类 名 称 ：IdentityserverConfig
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Extensions.ServiceConfigures.Authentication.IdentityServer4
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/1/29 14:43:58
* 更新时间 ：2022/1/29 14:43:58
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Domain.Models;
using Extensions.Helper;
using Extensions.ServiceConfigures.AppSettings;
using Extensions.ServiceConfigures.AppSettings.Model;
using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.ServiceConfigures.Authentication.IdentityServer4
{
    public class IdentityserverConfig
    {
        private static List<IndentityServerClient> indentityServerClients;
        private static ApiResource[] apiResources;

        public IdentityserverConfig(IConfiguration configuration)
        {
            indentityServerClients = (List<IndentityServerClient>)configuration.GetSection("Client").Get(typeof(List<IndentityServerClient>));
            apiResources = (ApiResource[])configuration.GetSection("ApiResource").Get(typeof(ApiResource[]));
        }
        public static IEnumerable<IdentityResource> GetIdentityResourceResources()
        {
            return new List<IdentityResource>
           {
               new IdentityResources.OpenId(), //必须要添加，否则报无效的scope错误
               new IdentityResources.Profile()
           };
        }

        // scopes define the API resources in your system
        public static IEnumerable<ApiResource> GetApiResources()
        {
            //return apiResources;
            return new List<ApiResource>
           {
              new ApiResource("Api1", "My API1"){ Scopes=new string[]{"Api1" } },
              new ApiResource("Api2", "My API2"){ Scopes=new string[]{"Api2" } }
           };
        }

        public static IEnumerable<ApiScope> ApiScopes =>
           new ApiScope[] { new ApiScope("Api1"), new ApiScope("Api2") };

        // clients want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients()
        {
            // client credentials client
            return new List<Client>
           {
               new Client
               {
                   ClientId = "client1",
                   AllowedGrantTypes = GrantTypes.ClientCredentials,

                   ClientSecrets =
                   {
                       new Secret("secret".Sha256())
                   },
                   AllowedScopes =new string[]{"Api1","Api2",IdentityServerConstants.StandardScopes.OpenId, //必须要添加，否则报forbidden错误
                 IdentityServerConstants.StandardScopes.Profile },

               },
 
               // resource owner password grant client
               //new Client
               //{
               //    ClientId = "client2",
               //    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

               //    ClientSecrets =
               //    {
               //        new Secret("secret".Sha256())
               //    },
               //    AllowedScopes = { "Api2",IdentityServerConstants.StandardScopes.OpenId, //必须要添加，否则报forbidden错误
               //  IdentityServerConstants.StandardScopes.Profile }
               //}
           };
        }
    }
}
