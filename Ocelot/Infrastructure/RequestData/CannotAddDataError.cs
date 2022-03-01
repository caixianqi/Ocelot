/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Infrastructure.RequestData
* 项目描述 ：
* 类 名 称 ：CannotAddDataError
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Infrastructure.RequestData
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/3/1 10:41:43
* 更新时间 ：2022/3/1 10:41:43
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Ocelot.Errors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Infrastructure.RequestData
{
    public class CannotAddDataError: Error
    {
        public CannotAddDataError(string message):base(message,OcelotErrorCode.CannotAddDataError)
        {
                
        }
    }
}
