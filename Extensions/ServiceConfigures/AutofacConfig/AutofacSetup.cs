/*----------------------------------------------------------------
* 项目名称 ：Extensions.ServiceConfigures.Autofac
* 项目描述 ：
* 类 名 称 ：AutofacSetup
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Extensions.ServiceConfigures.Autofac
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：Administrator
* 创建时间 ：2022/1/29 14:58:28
* 更新时间 ：2022/1/29 14:58:28
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Autofac;
using Repository.Base;

namespace Extensions.ServiceConfigures.AutofacConfig
{

    public class AutofacSetup : Autofac.Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {

            containerBuilder.RegisterGeneric(typeof(RepositoryBase<,>)).As(typeof(IRepository<,>)).InstancePerDependency();//注册仓储
            #region 方法3  使用 LoadFile 加载服务层的程序集  将程序集生成到bin目录 实现解耦 不需要引用
            //获取项目路径
            var basePath = AppContext.BaseDirectory;

            var RepositoryDllFile = Path.Combine(basePath, "Repository.dll");
            var RepositoryServices = Assembly.LoadFile(RepositoryDllFile);//直接采用加载文件的方法
            containerBuilder.RegisterAssemblyTypes(RepositoryServices).AsImplementedInterfaces();
            ;
            #endregion

            
        }
    }
}

