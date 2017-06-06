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
    /// 文章分类服务
    /// </summary>
    public class ArtTypeService : BaseService
    {
        /// <summary>
        /// 添加或修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ArtType AddOrUpdate(ArtType model)
        {
            if (model.ArtTypeId.IsNull())
            {
                model.ArtTypeId = ExtendUtil.GuidToString();
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
        /// 删除指定文章分类
        /// </summary>
        /// <param name="artTypeId">类别标识</param>
        /// <returns></returns>
        public bool Delete(string artTypeId)
        {
            var art = new ArtType { ArtTypeId = artTypeId };
            return Session.Delete(art) > 0;
        }

        /// <summary>
        /// 获取指定文章分类
        /// </summary>
        /// <param name="artTypeId">类别标识</param>
        /// <returns></returns>
        public ArtType GetArtType(string artTypeId)
        {
            var art = new ArtType { ArtTypeId = artTypeId };
            return Session.Select(art) ? art : null;
        }

        /// <summary>
        /// 获取文章分类列表
        /// </summary>
        /// <param name="pageSize">每页显示数,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="pageIndex">当前页,pageSize和pageIndex只要有一个是null,则返回所有记录</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        public List<ArtType> GetArtTypeList(int? pageSize, int? pageIndex, ref int totalCount)
        {
            var query = new QueryExpression();
            query.EntityType = typeof(ArtType);
            query.PageSize = pageSize;
            query.PageIndex = pageIndex;
            query.ReturnMatchedCount = false;
            query.Selects.Add(ArtType_.ALL);

            var artList = new List<ArtType>();
            totalCount = Session.SelectCollection(artList, query);

            return artList;
        }
    }
}
