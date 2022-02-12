/*----------------------------------------------------------------
* 项目名称 ：Domain.Models
* 项目描述 ：实体基础类
* 类 名 称 ：BaseEntity
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Domain.Models
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/1/27 16:03:53
* 更新时间 ：2022/1/27 16:03:53
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Domain.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class Entity
    {

        [Column("create_time")]
        /// <summary>
        /// 创建时间
        /// </summary>
        
        public DateTime CreateTime { get; set; } 

        [Column("update_time")]
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; } 

        [Required]
        /// <summary>
        /// 是否删除 默认为否（软删除）
        /// </summary>
        [Column("is_delete")]
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; } = false;

    }

    public class BaseEntity<T> : Entity
    {
        /// <summary>
        /// 数据唯一ID
        /// </summary>
        [Required]
        [Column("id")]
        [StringLength(50)]
        [Key]
        public T Id { get; set; }
    }
}
