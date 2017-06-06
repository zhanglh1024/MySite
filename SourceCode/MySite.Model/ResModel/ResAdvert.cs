using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Model
{
    /// <summary>
    /// 广告类输出参数
    /// </summary>
    public class ResAdvert
    {
        /// <summary>
        /// 标识
        /// </summary>
        public string AdvertId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string ReMark { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string Url { get; set; }
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
