﻿/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Validator
* 项目描述 ：
* 类 名 称 ：FileGlobalConfigurationFluentValidator
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Validator
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/3/1 10:12:10
* 更新时间 ：2022/3/1 10:12:10
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using FluentValidation;
using Ocelot.Configuration.File;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Validator
{
    public class FileGlobalConfigurationFluentValidator : AbstractValidator<FileGlobalConfiguration>
    {
        public FileGlobalConfigurationFluentValidator()
        {
                
        }
    }
}
