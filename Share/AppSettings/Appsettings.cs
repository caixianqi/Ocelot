/*----------------------------------------------------------------
* 项目名称 ：Extensions.ServiceConfigures.AppSettings
* 项目描述 ：Appsetting操作类
* 类 名 称 ：Appsettings
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Extensions.ServiceConfigures.AppSettings
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/1/29 15:35:34
* 更新时间 ：2022/1/29 15:35:34
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/


using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Extensions.ServiceConfigures.AppSettings
{
    public class Appsettings
    {
        static IConfiguration _configuration;
        public Appsettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Appsettings(string projectPath)
        {
            string Path = "appsettings.json";

            _configuration = new ConfigurationBuilder()
               .SetBasePath(projectPath)
               .Add(new JsonConfigurationSource { Path = Path, Optional = false, ReloadOnChange = true })//这样的话，可以直接读目录里的json文件，而不是 bin 文件夹下的，所以不用修改复制属性
               .Build();
        }

        /// <summary>
        /// 封装要操作的字符
        /// </summary>
        /// <param name="sections">节点配置</param>
        /// <returns></returns>
        public static string app(params string[] sections)
        {
            try
            {

                if (sections.Any())
                {
                    return _configuration[string.Join(":", sections)];
                }
            }
            catch (Exception) { }

            return "";
        }
    }
}
