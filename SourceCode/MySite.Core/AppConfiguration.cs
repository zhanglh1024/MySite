using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Core
{
    public static class AppConfiguration
    {
        /// <summary>
        /// 获取配置中指定Key的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetKey(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
