using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Model
{
    /// <summary>
    /// 个人日记输出类
    /// </summary>
    public class ResDailyInfo
    {
        /// <summary>
        /// 日记标识
        /// </summary>
        public string DailyId { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public string UpdateTime { get; set; }
    }
}
