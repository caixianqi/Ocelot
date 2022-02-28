/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Configuration
* 项目描述 ：
* 类 名 称 ：ServiceProviderConfiguration
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Configuration
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 14:21:18
* 更新时间 ：2022/2/28 14:21:18
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
    public class ServiceProviderConfiguration
    {
        public ServiceProviderConfiguration(string type, string host, int port, string token, string configurationKey, int pollingInterval, string @namespace = "")
        {
            ConfigurationKey = configurationKey;
            Host = host;
            Port = port;
            Token = token;
            Type = type;
            PollingInterval = pollingInterval;
            Namespace = @namespace;
        }

        public string Host { get; }

        public int Port { get; }

        public string Type { get; }

        public string Token { get; }

        public string ConfigurationKey { get; }

        public int PollingInterval { get; }

        public string Namespace { get; }
    }
}
