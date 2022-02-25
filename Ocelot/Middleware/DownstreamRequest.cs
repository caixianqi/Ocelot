/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Middleware
* 项目描述 ：
* 类 名 称 ：DownstreamRequest
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Middleware
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/25 17:47:55
* 更新时间 ：2022/2/25 17:47:55
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Ocelot.Middleware
{
    public class DownstreamRequest
    {
        private readonly HttpRequestMessage _request;

        public DownstreamRequest(HttpRequestMessage request)
        {
            _request = request;
            Method = _request.Method.Method;
            OriginalString = _request.RequestUri.OriginalString;
            Scheme = _request.RequestUri.Scheme;
            Host = _request.RequestUri.Host;
            Port = _request.RequestUri.Port;
            Headers = _request.Headers;
            AbsolutePath = _request.RequestUri.AbsolutePath;
            Query = _request.RequestUri.Query;
            Content = _request.Content;
        }

        public HttpRequestHeaders Headers { get; }

        public string Method { get; }

        public string OriginalString { get; }

        public string Scheme { get; set; }

        public string Host { get; set; }

        public int Port { get; set; }

        public string AbsolutePath { get; set; }

        public string Query { get; set; }

        public HttpContent Content { get; set; }

        public HttpRequestMessage ToHttpRequestMessage()
        {
            var uriBuilder = new UriBuilder
            {
                Port = Port,
                Host = Host,
                Path = AbsolutePath,
                Query = RemoveLeadingQuestionMark(Query),
                Scheme = Scheme
            };

            _request.RequestUri = uriBuilder.Uri;
            _request.Method = new HttpMethod(Method);
            return _request;
        }

        public string ToUri()
        {
            var uriBuilder = new UriBuilder
            {
                Port = Port,
                Host = Host,
                Path = AbsolutePath,
                Query = RemoveLeadingQuestionMark(Query),
                Scheme = Scheme
            };

            return uriBuilder.Uri.AbsoluteUri;
        }

        public override string ToString()
        {
            return ToUri();
        }

        private string RemoveLeadingQuestionMark(string query)
        {
            if (!string.IsNullOrEmpty(query) && query.StartsWith("?"))
            {
                return query.Substring(1);
            }

            return query;
        }
    }
}
