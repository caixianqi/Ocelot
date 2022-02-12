using Share.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models.User
{
    [Table("user")]
    [Description("用户")]
    public class UserEntity : BaseEntity<string>
    {
        public UserEntity()
        {
            base.Id = Guid.NewGuid().ToString();
        }
        /// <summary>
        /// 用户名
        /// </summary>
        [Column("username")]
        [Required]
        [Description("用户名")]
        public string UserName { get; set; }

        /// <summary>
        /// 密码（不映射）
        /// </summary>
        [Required]
        [NotMapped]
        public string Password { get; set; }

        /// <summary>
        /// 映射密码
        /// </summary>
        [Column("password")]
        [Required]
        [Description("密码")]
        private string EncryptPassword { get { return MD5Helper.GenerateMD5(Password); }set { } }


    }
}
