/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Configuration
* 项目描述 ：
* 类 名 称 ：RateLimitRule
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Configuration
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 15:19:27
* 更新时间 ：2022/2/28 15:19:27
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
    public class RateLimitRule
    {
        public RateLimitRule(string period, double periodTimespan, long limit)
        {
            Period = period;
            PeriodTimespan = periodTimespan;
            Limit = limit;
        }

        /// <summary>
        /// Rate limit period as in 1s, 1m, 1h,1d
        /// </summary>
        public string Period { get; private set; }

        public double PeriodTimespan { get; private set; }

        /// <summary>
        /// Maximum number of requests that a client can make in a defined period
        /// </summary>
        public long Limit { get; private set; }
    }
}
