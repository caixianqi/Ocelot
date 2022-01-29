/*----------------------------------------------------------------
* 项目名称 ：Repository.UnitOfWork
* 项目描述 ：
* 类 名 称 ：UnitOfWor
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Repository.UnitOfWork
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/1/29 10:41:02
* 更新时间 ：2022/1/29 10:41:02
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        private readonly ILogger _logger;
        public UnitOfWork(DbContext dbContext,ILogger<UnitOfWork> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }
        public void BeginTran()
        {
            _dbContext.Database.BeginTransaction();
        }

        public void CommitTran()
        {
            try
            {
                _dbContext.Database.CommitTransaction();
            }catch(Exception ex)
            {
                RollbackTran();
                _logger.LogError($"{ex.Message}\r\n{ex.InnerException}");
            }
        }

        public DbContext GetDbContext()
        {
            return _dbContext;
        }

        public void RollbackTran()
        {
            _dbContext.Database.RollbackTransaction();
        }
    }
}
