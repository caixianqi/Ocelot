/*----------------------------------------------------------------
* 项目名称 ：Domain.Models
* 项目描述 ：服务发现注册实体
* 类 名 称 ：ServiceRegisterModel
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Domain.Models
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/1/27 16:01:13
* 更新时间 ：2022/1/27 16:01:13
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    [Table("serviceregister")]
    [Description("服务发现实体")]
    public class ServiceRegisterEntity : BaseEntity<int>
    {
        [Required]
        [StringLength(50)]
        [Column("clientid")]
        /// <summary>
        /// 客户端Id
        /// </summary>
        public string ClientId { get; set; }

        [Required]
        [Column("secret")]
        /// <summary>
        /// 秘钥
        /// </summary>
        public string Secret { get; set; }

        [Required]
        [Column("service_name")]
        /// <summary>
        /// 服务名称
        /// </summary>
        public string ServiceName { get; set; }
    }
}
