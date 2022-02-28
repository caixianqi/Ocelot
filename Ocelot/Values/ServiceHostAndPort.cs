/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Values
* 项目描述 ：
* 类 名 称 ：ServiceHostAndPort
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Values
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/2/28 11:13:37
* 更新时间 ：2022/2/28 11:13:37
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Values
{
    public class ServiceHostAndPort
    {
        public ServiceHostAndPort(string downstreamHost,int downstreamPort)
        {
            DownstreamHost = downstreamHost;
            DownstreamPort = downstreamPort;
        }
        public ServiceHostAndPort(string downstreamHost, int downstreamPort, string scheme)
        : this(downstreamHost, downstreamPort) => Scheme = scheme;

        public string DownstreamHost { get; }

        public int DownstreamPort { get; }

        public string Scheme { get; }
    }
}
