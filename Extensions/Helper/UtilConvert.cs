/*----------------------------------------------------------------
* 项目名称 ：Extensions.Helper
* 项目描述 ：转换静态类
* 类 名 称 ：UtilConvert
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Extensions.Helper
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/1/29 16:36:19
* 更新时间 ：2022/1/29 16:36:19
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.Helper
{
    public static class UtilConvert
    {
        public static bool ObjToBool(this object obj)
        {
            var real = false;
            if (obj != null)
            {
                bool.TryParse(obj.ToString(), out real);
            }
            return real;
        }
    }
}
