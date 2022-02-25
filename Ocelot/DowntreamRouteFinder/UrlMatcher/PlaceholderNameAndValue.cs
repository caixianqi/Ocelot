/*----------------------------------------------------------------
* 项目名称 ：Ocelot.DowntreamRouteFinder.UrlMatcher
* 项目描述 ：
* 类 名 称 ：PlaceholderNameAndValue
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.DowntreamRouteFinder.UrlMatcher
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/25 17:14:16
* 更新时间 ：2022/2/25 17:14:16
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.DowntreamRouteFinder.UrlMatcher
{
    public class PlaceholderNameAndValue
    {
        public PlaceholderNameAndValue(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; private set; }
        public string Value { get; private set; }
    }
}
