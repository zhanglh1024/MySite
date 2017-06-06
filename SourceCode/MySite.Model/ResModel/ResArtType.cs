using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Model
{
    /// <summary>
    /// 文章类型输出类
    /// </summary>
    public class ResArtType
    {
        /// <summary>
        /// 类型标识
        /// </summary>
        public string ArtTypeId { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string ArtTypeName { get; set; }
        /// <summary>
        /// 父级类别标识
        /// </summary>
        public string ParentId { get; set; }
        /// <summary>
        /// 父级类别名称
        /// </summary>
        public string ParentName { get; set; }
        /// <summary>
        /// 状态:0-启用;1-禁用
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public string UpdateTime { get; set; }

    }
}
