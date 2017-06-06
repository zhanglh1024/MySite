using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Model
{
    /// <summary>
    /// 友情链接输出类
    /// </summary>
    public class ResFrLink
    {
        /// <summary>
        /// 链接标识
        /// </summary>
        public string FrLinkId { get; set; }
        /// <summary>
        /// 链接标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 备注、说明
        /// </summary>
        public string ReMark { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 排序字段
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 状态:0-启用;1-禁用
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public string UpdateTime { get; set; }
    }
}
