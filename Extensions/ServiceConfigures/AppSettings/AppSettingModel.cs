/*----------------------------------------------------------------
* 项目名称 ：Extensions.ServiceConfigures.AppSettings
* 项目描述 ：AppSetting--Model类
* 类 名 称 ：AppSettingModel
* 类 描 述 ：json转换成Model类
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Extensions.ServiceConfigures.AppSettings
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/1/29 17:25:41
* 更新时间 ：2022/1/29 17:25:41
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.ServiceConfigures.AppSettings
{
    public class AppSettingModel
    {
        /// <summary>
        /// 客户端Id
        /// </summary>
        public string cilenId { get; set; }

        /// <summary>
        /// 授权类型
        /// </summary>
        public List<string> allowedGrantTypes { get; set; }

    }


}
