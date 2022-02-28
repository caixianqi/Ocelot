/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Configuration
* 项目描述 ：
* 类 名 称 ：QoSOptions
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Configuration
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/2/28 10:30:46
* 更新时间 ：2022/2/28 10:30:46
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
    public class QoSOptions
    {
        public QoSOptions(
        int exceptionsAllowedBeforeBreaking,
        int durationofBreak,
        int timeoutValue,
        string key,
        string timeoutStrategy = "Pessimistic")
        {
            ExceptionsAllowedBeforeBreaking = exceptionsAllowedBeforeBreaking;
            DurationOfBreak = durationofBreak;
            TimeoutValue = timeoutValue;
            TimeoutStrategy = timeoutStrategy;
            Key = key;
        }

        public int ExceptionsAllowedBeforeBreaking { get; }

        public int DurationOfBreak { get; }

        public int TimeoutValue { get; }

        public string TimeoutStrategy { get; }

        public bool UseQos => ExceptionsAllowedBeforeBreaking > 0 || TimeoutValue > 0;

        public string Key { get; }
    }
}
