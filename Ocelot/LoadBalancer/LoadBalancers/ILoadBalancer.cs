/*----------------------------------------------------------------
* 项目名称 ：Ocelot.LoadBalancer.LoadBalancers
* 项目描述 ：
* 类 名 称 ：ILoadBalancer
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.LoadBalancer.LoadBalancers
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/2/28 10:51:43
* 更新时间 ：2022/2/28 10:51:43
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Ocelot.Middleware;
using Ocelot.Responses;
using Ocelot.Values;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ocelot.LoadBalancer.LoadBalancers
{
    interface ILoadBalancer
    {
        Task<Response<ServiceHostAndPort>> Lease(DownstreamContext context);

        void Release(ServiceHostAndPort hostAndPort);
    }
}
