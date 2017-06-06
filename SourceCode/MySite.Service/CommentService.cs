using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySite.Core;
using MySite.Model;
using Titan;

namespace MySite.Service
{
    /// <summary>
    /// 文章评论相关服务
    /// </summary>
    public class CommentService : BaseService
    { 
        /// <summary>
        /// 添加或修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Comment AddOrUpdate(Comment model)
        {
            if (model.CommentId.IsNull())
            {
                model.CommentId = ExtendUtil.GuidToString();
                model.UpdateTime = DateTime.Now;
                Session.Insert(model);
            }
            else
            {
                model.UpdateTime = DateTime.Now;
                Session.Update(model);
            }
            return model;
        }

        /// <summary>
        /// 删除指定指定评论
        /// </summary>
        /// <param name="dailyId">个人日记标识</param>
        /// <returns></returns>
        public bool Delete(string commentId)
        {
            var co = new Comment { CommentId = commentId };
            return Session.Delete(co) > 0;
        }

        /// <summary>
        /// 获取指定书籍的评论列表
        /// </summary>
        /// <param name="articleId">文章标识</param>
        /// <param name="pageSize">每页显示数,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="pageIndex">当前页,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        public List<Comment> GetCommentList(string articleId, int? pageSize, int? pageIndex, ref int totalCount)
        {
            var query = new QueryExpression();
            query.EntityType = typeof(Comment);
            query.PageSize = pageSize;
            query.PageIndex = pageIndex;
            query.ReturnMatchedCount = false;
            query.Selects.Add(Comment_.ALL);

            query.Wheres.Add(Comment_.ArticleId.TEqual(articleId));

            query.OrderBys.Add(Comment_.LightCount.Desc);
            query.OrderBys.Add(Comment_.UpdateTime.Desc);

            var cList = new List<Comment>();
            totalCount = Session.SelectCollection(cList, query);

            return cList;
        }

        /// <summary>
        /// 获取指定评论的父级评论列表
        /// </summary>
        /// <param name="parentId">父级标识</param>
        /// <param name="pageSize">每页显示数,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="pageIndex">当前页,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        public List<Comment> GetCommentListByParentId(string parentId, int? pageSize, int? pageIndex, ref int totalCount)
        {
            var query = new QueryExpression();
            query.EntityType = typeof(Comment);
            query.PageSize = pageSize;
            query.PageIndex = pageIndex;
            query.ReturnMatchedCount = false;
            query.Selects.Add(Comment_.ALL);

            query.Wheres.Add(Comment_.ParentId.TEqual(parentId));
            
            query.OrderBys.Add(Comment_.UpdateTime.Asc);

            var cList = new List<Comment>();
            totalCount = Session.SelectCollection(cList, query);

            return cList;
        }
    }
}
