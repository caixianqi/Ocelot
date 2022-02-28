﻿/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Values
* 项目描述 ：
* 类 名 称 ：DownstreamPathTemplate
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Values
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 15:28:23
* 更新时间 ：2022/2/28 15:28:23
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Values
{
    public class DownstreamPathTemplate
    {
        public DownstreamPathTemplate(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}