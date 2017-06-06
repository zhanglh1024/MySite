using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Model.ResModel
{
    /// <summary>
    /// 评论输出类
    /// </summary>
    public class ResComment
    {
        /// <summary>
        /// 评论标识
        /// </summary>
        public string CommentId { get; set; }
        /// <summary>
        /// 用户标识
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 文章标识
        /// </summary>
        public string ArticleId { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 点亮数
        /// </summary>
        public int LightCount { get; set; }
        /// <summary>
        /// 父级标识
        /// </summary>
        public string ParentId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public string UpdateTime { get; set; }

    }
}
