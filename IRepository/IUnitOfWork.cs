/*----------------------------------------------------------------
* 项目名称 ：Repository.UnitOfWork
* 项目描述 ：工作单元接口
* 类 名 称 ：IUnitOfWork
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Repository.UnitOfWork
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒  
* 创建时间 ：2022/1/29 9:52:07
* 更新时间 ：2022/1/29 9:52:07
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        DbContext GetDbContext();

        void BeginTran();

        void CommitTran();
        void RollbackTran();
    }
}
