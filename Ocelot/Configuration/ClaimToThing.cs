﻿/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Configuration
* 项目描述 ：
* 类 名 称 ：ClaimToThing
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Configuration
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 15:22:39
* 更新时间 ：2022/2/28 15:22:39
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Configuration
{
    public class ClaimToThing
    {
        public ClaimToThing(string existingKey, string newKey, string delimiter, int index)
        {
            NewKey = newKey;
            Delimiter = delimiter;
            Index = index;
            ExistingKey = existingKey;
        }

        public string ExistingKey { get; private set; }
        public string NewKey { get; private set; }
        public string Delimiter { get; private set; }
        public int Index { get; private set; }
    }
}
