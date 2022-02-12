using Domain.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    /// <summary>
    /// 添加一个创建人字段BaseEntity
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseUserEntity<T> : BaseEntity<T>
    {
        [Required]
        public UserEntity User { get; set; }
    }
}
