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
    /// 文章相关服务
    /// </summary>
    public class ArticleService : BaseService
    {
        /// <summary>
        /// 添加或修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Article AddOrUpdate(Article model)
        {
            if (model.ArticleId.IsNull())
            {
                model.ArticleId = ExtendUtil.GuidToString();
                model.PublishDate = DateTime.Now;
                Session.Insert(model);
            }
            else
            {
                model.PublishDate = DateTime.Now;
                Session.Update(model);
            }
            return model;
        }

        /// <summary>
        /// 删除指定文章信息
        /// </summary>
        /// <param name="articleId">文章标识</param>
        /// <returns></returns>
        public bool Delete(string articleId)
        {
            var ar = new Article { ArticleId = articleId };
            return Session.Delete(ar) > 0;
        }

        /// <summary>
        /// 获取指定文章信息
        /// </summary>
        /// <param name="articleId">走马灯标识</param>
        /// <returns></returns>
        public Article GetArticle(string articleId)
        {
            var ar = new Article { ArticleId = articleId };
            return Session.Select(ar) ? ar : null;
        }

        /// <summary>
        /// 获取文章列表
        /// </summary>
        /// <param name="typeId">分类标识</param>
        /// <param name="status">状态：0--新;1--正常;2--热门</param>
        /// <param name="tag">标签</param>
        /// <param name="orderby">排序字段：CLICK|DATE|COMMEND</param>
        /// <param name="pageSize">每页显示数,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="pageIndex">当前页,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        public List<Article> GetArticleList(string typeId, int status, string tag, string orderby, int? pageSize, int? pageIndex, ref int totalCount)
        {
            var query = new QueryExpression();
            query.EntityType = typeof(Article);
            query.PageSize = pageSize;
            query.PageIndex = pageIndex;
            query.ReturnMatchedCount = false;
            query.Selects.Add(Article_.ALL);

            query.Wheres.Add(Article_.Status.TEqual(status));
            if (!typeId.IsNull())
                query.Wheres.Add(Article_.ArtTypeId.TEqual(typeId));
            if (!tag.IsNull())
                query.Wheres.Add(Article_.Tag.TEqual(status));

            switch (orderby)
            {
                case "CLICK": query.OrderBys.Add(Article_.ClickCount.Desc); break;
                case "DATE": query.OrderBys.Add(Article_.PublishDate.Desc); break;
                case "COMMEND": query.OrderBys.Add(Article_.IsCommend.Desc); break;
            }

            query.OrderBys.Add(Article_.Status.Asc);

            var arList = new List<Article>();
            totalCount = Session.SelectCollection(arList, query);

            return arList;
        }
    }
}
