/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Requester
* 项目描述 ：
* 类 名 称 ：QosDelegatingHandlerDelegate
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Requester
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/3/1 10:15:02
* 更新时间 ：2022/3/1 10:15:02
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Ocelot.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Ocelot.Requester
{
    public delegate DelegatingHandler QosDelegatingHandlerDelegate(DownstreamReRoute reRoute, IOcelotLoggerFactory logger);
}
