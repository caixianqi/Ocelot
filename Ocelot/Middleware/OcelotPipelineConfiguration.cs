/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Middleware
* 项目描述 ：
* 类 名 称 ：OcelotPipelineConfiguration
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Middleware
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/2/28 16:35:49
* 更新时间 ：2022/2/28 16:35:49
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Ocelot.Middleware.Pipeline;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ocelot.Middleware
{
    public class OcelotPipelineConfiguration
    {
        /// <summary>
        /// This is called after the global error handling middleware so any code before calling next.invoke
        /// is the next thing called in the Ocelot pipeline. Anything after next.invoke is the last thing called
        /// in the Ocelot pipeline before we go to the global error handler.
        /// </summary>
        public Func<DownstreamContext, Func<Task>, Task> PreErrorResponderMiddleware { get; set; }

        /// <summary>
        /// This is to allow the user to run any extra authentication before the Ocelot authentication
        /// kicks in
        /// </summary>
        public Func<DownstreamContext, Func<Task>, Task> PreAuthenticationMiddleware { get; set; }

        /// <summary>
        /// This allows the user to completely override the ocelot authentication middleware
        /// </summary>
        public Func<DownstreamContext, Func<Task>, Task> AuthenticationMiddleware { get; set; }

        /// <summary>
        /// This is to allow the user to run any extra authorisation before the Ocelot authentication
        /// kicks in
        /// </summary>
        public Func<DownstreamContext, Func<Task>, Task> PreAuthorisationMiddleware { get; set; }

        /// <summary>
        /// This allows the user to completely override the ocelot authorisation middleware
        /// </summary>
        public Func<DownstreamContext, Func<Task>, Task> AuthorisationMiddleware { get; set; }

        /// <summary>
        /// This allows the user to implement there own query string manipulation logic
        /// </summary>
        public Func<DownstreamContext, Func<Task>, Task> PreQueryStringBuilderMiddleware { get; set; }

        /// <summary>
        /// This is an extension that will branch to different pipes
        /// </summary>
        public List<Func<IOcelotPipelineBuilder, Func<DownstreamContext, bool>>> MapWhenOcelotPipeline { get; } = new List<Func<IOcelotPipelineBuilder, Func<DownstreamContext, bool>>>();
    }
}
