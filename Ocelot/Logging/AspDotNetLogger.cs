/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Logging
* 项目描述 ：
* 类 名 称 ：AspDotNetLogger
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Logging
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/3/1 10:56:12
* 更新时间 ：2022/3/1 10:56:12
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
    public class AspDotNetLogger : IOcelotLogger
    {
        private readonly ILogger _logger;
        private readonly IRequestScopedDataRepository _scopedDataRepository;
        private readonly Func<string, Exception, string> _func;

        public AspDotNetLogger(ILogger logger, IRequestScopedDataRepository scopedDataRepository)
        {
            _logger = logger;
            _scopedDataRepository = scopedDataRepository;
            _func = (state, exception) =>
            {
                if (exception == null)
                {
                    return state;
                }
                else
                {
                    return $"{state}, exception: {exception}";
                }
            };
        }

        public void LogTrace(string message)
        {
            var requestId = GetOcelotRequestId();
            var previousRequestId = GetOcelotPreviousRequestId();

            var state = $"requestId: {requestId}, previousRequestId: {previousRequestId}, message: {message}";

            _logger.Log(LogLevel.Trace, default(EventId), state, null, _func);
        }

        public void LogDebug(string message)
        {
            var requestId = GetOcelotRequestId();
            var previousRequestId = GetOcelotPreviousRequestId();

            var state = $"requestId: {requestId}, previousRequestId: {previousRequestId}, message: {message}";

            _logger.Log(LogLevel.Debug, default(EventId), state, null, _func);
        }

        public void LogInformation(string message)
        {
            var requestId = GetOcelotRequestId();
            var previousRequestId = GetOcelotPreviousRequestId();

            var state = $"requestId: {requestId}, previousRequestId: {previousRequestId}, message: {message}";

            _logger.Log(LogLevel.Information, default(EventId), state, null, _func);
        }

        public void LogWarning(string message)
        {
            var requestId = GetOcelotRequestId();
            var previousRequestId = GetOcelotPreviousRequestId();

            var state = $"requestId: {requestId}, previousRequestId: {previousRequestId}, message: {message}";

            _logger.Log(LogLevel.Warning, default(EventId), state, null, _func);
        }

        public void LogError(string message, Exception exception)
        {
            var requestId = GetOcelotRequestId();
            var previousRequestId = GetOcelotPreviousRequestId();

            var state = $"requestId: {requestId}, previousRequestId: {previousRequestId}, message: {message}";

            _logger.Log(LogLevel.Error, default(EventId), state, exception, _func);
        }

        public void LogCritical(string message, Exception exception)
        {
            var requestId = GetOcelotRequestId();
            var previousRequestId = GetOcelotPreviousRequestId();

            var state = $"requestId: {requestId}, previousRequestId: {previousRequestId}, message: {message}";

            _logger.Log(LogLevel.Critical, default(EventId), state, exception, _func);
        }

        private string GetOcelotRequestId()
        {
            var requestId = _scopedDataRepository.Get<string>("RequestId");

            if (requestId == null || requestId.IsError)
            {
                return "no request id";
            }

            return requestId.Data;
        }

        private string GetOcelotPreviousRequestId()
        {
            var requestId = _scopedDataRepository.Get<string>("PreviousRequestId");

            if (requestId == null || requestId.IsError)
            {
                return "no previous request id";
            }

            return requestId.Data;
        }
    }
}
