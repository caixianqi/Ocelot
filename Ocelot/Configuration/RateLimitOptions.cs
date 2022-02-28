/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Configuration
* 项目描述 ：
* 类 名 称 ：RateLimitOptions
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Configuration
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 15:17:07
* 更新时间 ：2022/2/28 15:17:07
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
    public class RateLimitOptions
    {
        private readonly Func<List<string>> _getClientWhitelist;

        public RateLimitOptions(bool enableRateLimiting, string clientIdHeader, Func<List<string>> getClientWhitelist, bool disableRateLimitHeaders,
            string quotaExceededMessage, string rateLimitCounterPrefix, RateLimitRule rateLimitRule, int httpStatusCode)
        {
            EnableRateLimiting = enableRateLimiting;
            ClientIdHeader = clientIdHeader;
            _getClientWhitelist = getClientWhitelist;
            DisableRateLimitHeaders = disableRateLimitHeaders;
            QuotaExceededMessage = quotaExceededMessage;
            RateLimitCounterPrefix = rateLimitCounterPrefix;
            RateLimitRule = rateLimitRule;
            HttpStatusCode = httpStatusCode;
        }

        public RateLimitRule RateLimitRule { get; private set; }

        /// <summary>
        /// Gets the list of white listed clients
        /// </summary>
        public List<string> ClientWhitelist { get => _getClientWhitelist(); }

        /// <summary>
        /// Gets or sets the HTTP header that holds the client identifier, by default is X-ClientId
        /// </summary>
        public string ClientIdHeader { get; private set; }

        /// <summary>
        /// Gets or sets the HTTP Status code returned when rate limiting occurs, by default value is set to 429 (Too Many Requests)
        /// </summary>
        public int HttpStatusCode { get; private set; }

        /// <summary>
        /// Gets or sets a value that will be used as a formatter for the QuotaExceeded response message.
        /// If none specified the default will be:
        /// API calls quota exceeded! maximum admitted {0} per {1}
        /// </summary>
        public string QuotaExceededMessage { get; private set; }

        /// <summary>
        /// Gets or sets the counter prefix, used to compose the rate limit counter cache key
        /// </summary>
        public string RateLimitCounterPrefix { get; private set; }

        /// <summary>
        /// Enables endpoint rate limiting based URL path and HTTP verb
        /// </summary>
        public bool EnableRateLimiting { get; private set; }

        /// <summary>
        /// Disables X-Rate-Limit and Rety-After headers
        /// </summary>
        public bool DisableRateLimitHeaders { get; private set; }
    }
}
