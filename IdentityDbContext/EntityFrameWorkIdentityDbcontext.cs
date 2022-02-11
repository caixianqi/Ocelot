/*----------------------------------------------------------------
* 项目名称 ：IdentityDbContext
* 项目描述 ：
* 类 名 称 ：EntityFrameWorkIdentityDbcontext
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：IdentityDbContext
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/1/28 9:48:22
* 更新时间 ：2022/1/28 9:48:22
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Domain.Models;
using Extensions.ServiceConfigures.AppSettings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityDbContext
{
    public class EntityFrameWorkIdentityDbcontext:DbContext
    {
        public EntityFrameWorkIdentityDbcontext(DbContextOptions<EntityFrameWorkIdentityDbcontext> options):base(options)           
        {
                
        }

        public DbSet<ServiceRegisterEntity> serviceRegisterEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }

        /// <summary>
        /// 初始化插入数据种子
        /// </summary>
        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceRegisterEntity>().HasData(new ServiceRegisterEntity
            {
                
            });
        }
    }
}
