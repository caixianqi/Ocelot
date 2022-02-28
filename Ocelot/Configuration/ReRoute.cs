/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Configuration
* 项目描述 ：
* 类 名 称 ：ReRoute
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Configuration
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 15:51:06
* 更新时间 ：2022/2/28 15:51:06
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Ocelot.Configuration.File;
using Ocelot.Values;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Ocelot.Configuration
{
    public class ReRoute
    {
        public ReRoute(List<DownstreamReRoute> downstreamReRoute,
           List<AggregateReRouteConfig> downstreamReRouteConfig,
           List<HttpMethod> upstreamHttpMethod,
           UpstreamPathTemplate upstreamTemplatePattern,
           string upstreamHost,
           string aggregator)
        {
            UpstreamHost = upstreamHost;
            DownstreamReRoute = downstreamReRoute;
            DownstreamReRouteConfig = downstreamReRouteConfig;
            UpstreamHttpMethod = upstreamHttpMethod;
            UpstreamTemplatePattern = upstreamTemplatePattern;
            Aggregator = aggregator;
        }

        public UpstreamPathTemplate UpstreamTemplatePattern { get; private set; }
        public List<HttpMethod> UpstreamHttpMethod { get; private set; }
        public string UpstreamHost { get; private set; }
        public List<DownstreamReRoute> DownstreamReRoute { get; private set; }
        public List<AggregateReRouteConfig> DownstreamReRouteConfig { get; private set; }
        public string Aggregator { get; private set; }
    }
}
