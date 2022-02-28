/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Values
* 项目描述 ：
* 类 名 称 ：UpstreamPathTemplate
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Values
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 15:03:43
* 更新时间 ：2022/2/28 15:03:43
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ocelot.Values
{
    public class UpstreamPathTemplate
    {
        public UpstreamPathTemplate(string template, int priority, bool containsQueryString, string originalValue)
        {
            Template = template;
            Priority = priority;
            ContainsQueryString = containsQueryString;
            OriginalValue = originalValue;
            Pattern = template == null ?
                new Regex("$^", RegexOptions.Compiled | RegexOptions.Singleline) :
                new Regex(template, RegexOptions.Compiled | RegexOptions.Singleline);
        }

        public string Template { get; }

        public int Priority { get; }

        public bool ContainsQueryString { get; }

        public string OriginalValue { get; }

        public Regex Pattern { get; }
    }
}
