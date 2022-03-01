/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Logging
* 项目描述 ：
* 类 名 称 ：IOcelotLogger
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Logging
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/3/1 10:21:04
* 更新时间 ：2022/3/1 10:21:04
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Logging
{
    public interface IOcelotLogger
    {
        void LogTrace(string message);

        void LogDebug(string message);

        void LogInformation(string message);

        void LogWarning(string message);

        void LogError(string message, Exception exception);

        void LogCritical(string message, Exception exception);
    }
}
