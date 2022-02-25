/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Middleware
* 项目描述 ：
* 类 名 称 ：DownstreamResponse
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Middleware
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/25 17:49:27
* 更新时间 ：2022/2/25 17:49:27
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Ocelot.Middleware
{
    public class DownstreamResponse
    {
        public DownstreamResponse(HttpContent content, HttpStatusCode statusCode, List<Header> headers, string reasonPhrase)
        {
            Content = content;
            StatusCode = statusCode;
            Headers = headers ?? new List<Header>();
            ReasonPhrase = reasonPhrase;
        }

        public DownstreamResponse(HttpResponseMessage response)
            : this(response.Content, response.StatusCode, response.Headers.Select(x => new Header(x.Key, x.Value)).ToList(), response.ReasonPhrase)
        {
        }

        public DownstreamResponse(HttpContent content, HttpStatusCode statusCode, IEnumerable<KeyValuePair<string, IEnumerable<string>>> headers, string reasonPhrase)
            : this(content, statusCode, headers.Select(x => new Header(x.Key, x.Value)).ToList(), reasonPhrase)
        {
        }

        public HttpContent Content { get; }
        public HttpStatusCode StatusCode { get; }
        public List<Header> Headers { get; }
        public string ReasonPhrase { get; }
    }
}
