/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Configuration
* 项目描述 ：
* 类 名 称 ：HttpHandlerOptions
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Configuration
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 10:46:17
* 更新时间 ：2022/2/28 10:46:17
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
    public class HttpHandlerOptions
    {
        public HttpHandlerOptions(bool allowAutoRedirect, bool useCookieContainer, bool useTracing, bool useProxy, int maxConnectionsPerServer)
        {
            AllowAutoRedirect = allowAutoRedirect;
            UseCookieContainer = useCookieContainer;
            UseTracing = useTracing;
            UseProxy = useProxy;
            MaxConnectionsPerServer = maxConnectionsPerServer;
        }


        /// <summary>
        /// Specify if auto redirect is enabled
        /// </summary>
        /// <value>AllowAutoRedirect</value>
        public bool AllowAutoRedirect { get; private set; }

        /// <summary>
        /// Specify is handler has to use a cookie container
        /// </summary>
        /// <value>UseCookieContainer</value>
        public bool UseCookieContainer { get; private set; }

        /// <summary>
        /// Specify is handler has to use a opentracing
        /// </summary>
        /// <value>UseTracing</value>
        public bool UseTracing { get; private set; }

        /// <summary>
        /// Specify if handler has to use a proxy
        /// </summary>
        /// <value>UseProxy</value>
        public bool UseProxy { get; private set; }

        /// <summary>
        /// Specify the maximum of concurrent connection to a network endpoint
        /// </summary>
        /// <value>MaxConnectionsPerServer</value>
        public int MaxConnectionsPerServer { get; private set; }
    }
}
