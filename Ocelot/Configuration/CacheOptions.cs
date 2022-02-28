/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Configuration
* 项目描述 ：
* 类 名 称 ：CacheOptions
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Configuration
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 15:00:21
* 更新时间 ：2022/2/28 15:00:21
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
    public class CacheOptions
    {
        public CacheOptions(int ttlSeconds, string region)
        {
            TtlSeconds = ttlSeconds;
            Region = region;
        }

        public int TtlSeconds { get; private set; }

        public string Region { get; private set; }
    }
}
