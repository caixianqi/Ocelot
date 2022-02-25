using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api1Server
{
    public class DownstreamContext
    {
        public DownstreamContext(HttpContext httpContext)
        {
            HttpContext = httpContext;
        }
        public HttpContext HttpContext { get; }
    }
}
