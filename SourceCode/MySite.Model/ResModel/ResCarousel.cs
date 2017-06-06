using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Model
{
    /// <summary>
    /// 走马灯输出类
    /// </summary>
    public class ResCarousel
    {
        /// <summary>
        /// 走马灯标识
        /// </summary>
        public string CarouselId { get; set; }
        /// <summary>
        /// 走马灯名称
        /// </summary>
        public string CarouselName { get; set; }
        /// <summary>
        /// 类型：LINK|IMAGE|VEDIO
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 状态：0-启用;1-禁用
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public string UpdateTime { get; set; }
    }
}
