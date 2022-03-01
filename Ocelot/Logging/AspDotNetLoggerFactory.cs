/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Logging
* 项目描述 ：
* 类 名 称 ：AspDotNetLoggerFactory
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Logging
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/3/1 10:32:20
* 更新时间 ：2022/3/1 10:32:20
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Microsoft.Extensions.Logging;
using Ocelot.Infrastructure.RequestData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Logging
{
    public class AspDotNetLoggerFactory: IOcelotLoggerFactory
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly IRequestScopedDataRepository _scopedDataRepository;

        public AspDotNetLoggerFactory(ILoggerFactory loggerFactory, IRequestScopedDataRepository scopedDataRepository)
        {
            _loggerFactory = loggerFactory;
            _scopedDataRepository = scopedDataRepository;
        }

        public IOcelotLogger CreateLogger<T>()
        {
            var logger = _loggerFactory.CreateLogger<T>();
            return new AspDotNetLogger(logger, _scopedDataRepository);
        }
    }
}
