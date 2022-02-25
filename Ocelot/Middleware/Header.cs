/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Middleware
* 项目描述 ：
* 类 名 称 ：Header
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Middleware
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/2/25 17:34:40
* 更新时间 ：2022/2/25 17:34:40
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Middleware
{
    public class Header
    {
        public Header(string key, IEnumerable<string> values)
        {
            Key = key;
            Values = values ?? new List<string>();
        }

        public string Key { get; }
        public IEnumerable<string> Values { get; }
    }
}
