﻿/*----------------------------------------------------------------
* 项目名称 ：TestFeign
* 项目描述 ：
* 类 名 称 ：Interface1
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：TestFeign
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/2/7 11:44:37
* 更新时间 ：2022/2/7 11:44:37
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Feign;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestFeign
{
    [FeignClient("test-service", Url = "http://testservice.xx.com")]
    interface Interface1
    {
    }
}
