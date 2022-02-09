/*----------------------------------------------------------------
* 项目名称 ：Extensions.ServiceConfigures.AppSettings.Model
* 项目描述 ：
* 类 名 称 ：IndentityServerClientModel
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Extensions.ServiceConfigures.AppSettings.Model
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/7 15:47:04
* 更新时间 ：2022/2/7 15:47:04
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.ServiceConfigures.AppSettings.Model
{
    public class IndentityServerClient
    {
        /// <summary>
        /// 客户端Id
        /// </summary>
        public string Clientid { get; set; }

        /// <summary>
        /// 授权类型
        /// </summary>
        public string AllowedGrantTypes { get; set; }
    }
}
