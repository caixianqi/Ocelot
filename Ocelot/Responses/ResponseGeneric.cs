/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Responses
* 项目描述 ：
* 类 名 称 ：ResponseGeneric
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Responses
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/2/28 10:55:02
* 更新时间 ：2022/2/28 10:55:02
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Ocelot.Errors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Responses
{
    public abstract class Response<T> : Response
#pragma warning restore SA1649 // File name must match first type name
    {
        protected Response(T data)
        {
            Data = data;
        }

        protected Response(List<Error> errors) : base(errors)
        {
        }

        public T Data { get; private set; }
    }
}
