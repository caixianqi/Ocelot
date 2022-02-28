﻿/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Configuration.Creator
* 项目描述 ：
* 类 名 称 ：IInternalConfigurationCreator
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Configuration.Creator
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/28 17:24:06
* 更新时间 ：2022/2/28 17:24:06
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Ocelot.Configuration.File;
using Ocelot.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ocelot.Configuration.Creator
{
    public interface IInternalConfigurationCreator
    {
        Task<Response<IInternalConfiguration>> Create(FileConfiguration fileConfiguration);
    }
}