/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Values
* 项目描述 ：
* 类 名 称 ：Service
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Values
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 11:19:59
* 更新时间 ：2022/2/28 11:19:59
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
    public class Service
    {
        public Service(string name,
        ServiceHostAndPort hostAndPort,
        string id,
        string version,
        IEnumerable<string> tags)
        {
            Name = name;
            HostAndPort = hostAndPort;
            Id = id;
            Version = version;
            Tags = tags;
        }

        public string Id { get; }

        public string Name { get; }

        public string Version { get; }

        public IEnumerable<string> Tags { get; }

        public ServiceHostAndPort HostAndPort { get; }
    }
}
