/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Configuration
* 项目描述 ：
* 类 名 称 ：InternalConfiguration
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Configuration
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 17:27:45
* 更新时间 ：2022/2/28 17:27:45
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Configuration
{
    public class InternalConfiguration: IInternalConfiguration
    {
        public InternalConfiguration(
           List<ReRoute> reRoutes,
           string administrationPath,
           ServiceProviderConfiguration serviceProviderConfiguration,
           string requestId,
           LoadBalancerOptions loadBalancerOptions,
           string downstreamScheme,
           QoSOptions qoSOptions,
           HttpHandlerOptions httpHandlerOptions,
           Version downstreamHttpVersion)
        {
            ReRoutes = reRoutes;
            AdministrationPath = administrationPath;
            ServiceProviderConfiguration = serviceProviderConfiguration;
            RequestId = requestId;
            LoadBalancerOptions = loadBalancerOptions;
            DownstreamScheme = downstreamScheme;
            QoSOptions = qoSOptions;
            HttpHandlerOptions = httpHandlerOptions;
            DownstreamHttpVersion = downstreamHttpVersion;
        }

        public List<ReRoute> ReRoutes { get; }
        public string AdministrationPath { get; }
        public ServiceProviderConfiguration ServiceProviderConfiguration { get; }
        public string RequestId { get; }
        public LoadBalancerOptions LoadBalancerOptions { get; }
        public string DownstreamScheme { get; }
        public QoSOptions QoSOptions { get; }
        public HttpHandlerOptions HttpHandlerOptions { get; }

        public Version DownstreamHttpVersion { get; }
    }
}
