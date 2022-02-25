/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Error
* 项目描述 ：
* 类 名 称 ：Error
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Error
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/25 16:56:28
* 更新时间 ：2022/2/25 16:56:28
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Error
{
    public abstract class Error
    {
        public Error(string message, OcelotErrorCode code)
        {
            Message = message;
            Code = code;
        }

        public string Message { get; private set; }
        public OcelotErrorCode Code { get; private set; }

        public override string ToString()
        {
            return Message;
        }
    }
}
